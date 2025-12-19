using System;
using System.Data;
using System.Windows.Forms;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories;

namespace LibraryManagementSystem
{
    public partial class MembersForm : Form
    {
        private readonly MemberRepository _repo = new();
        private int selectedMemberId = 0;

        public MembersForm()
        {
            InitializeComponent();
        }

        private void MembersForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
            UpdateButtonsState();
        }

        void LoadMembers()
        {
            DataTable dt = _repo.GetAll();

            if (!dt.Columns.Contains("Index"))
                dt.Columns.Add("Index", typeof(int));

            for (int i = 0; i < dt.Rows.Count; i++)
                dt.Rows[i]["Index"] = i + 1;

            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.Columns.Clear();
            dgvMembers.DataSource = dt;

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIndex",
                HeaderText = "#",
                DataPropertyName = "Index",
                Width = 50
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFullName",
                HeaderText = "Full Name",
                DataPropertyName = "FullName"
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPhone",
                HeaderText = "Phone",
                DataPropertyName = "Phone"
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEmail",
                HeaderText = "Email",
                DataPropertyName = "Email"
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                _repo.Add(new Member
                {
                    FullName = txtFullName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                });

                LoadMembers();
                ClearFields();

                MessageBox.Show(
                    "Member added successfully",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                // Unique constraint violation
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show(
                        "This email already exists.\nPlease use another email.",
                        "Duplicate Email",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtEmail.Focus();
                    txtEmail.SelectAll();
                }
                else
                {
                    MessageBox.Show(
                        ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMemberId == 0) return;

            _repo.Update(new Member
            {
                MemberID = selectedMemberId,
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim()
            });

            LoadMembers();
            ClearFields();

            MessageBox.Show(
                    "Member updated successfully",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMemberId == 0) return;

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this member?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            _repo.Delete(selectedMemberId);
            LoadMembers();
            ClearFields();
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView drv = dgvMembers.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (drv == null) return;

            selectedMemberId = Convert.ToInt32(drv["MemberID"]);

            txtFullName.Text = drv["FullName"].ToString();
            txtPhone.Text = drv["Phone"].ToString();
            txtEmail.Text = drv["Email"].ToString();

            UpdateButtonsState();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvMembers.DataSource is not DataTable dt) return;

            dt.DefaultView.RowFilter =
                $"FullName LIKE '%{txtSearch.Text}%' OR Phone LIKE '%{txtSearch.Text}%'";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        void ClearFields()
        {
            selectedMemberId = 0;
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            dgvMembers.ClearSelection();
            UpdateButtonsState();
            txtFullName.Focus();
        }

        void UpdateButtonsState()
        {
            bool hasSelection = selectedMemberId != 0;
            btnUpdate.Enabled = hasSelection;
            btnDelete.Enabled = hasSelection;
        }

        bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill all fields",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
