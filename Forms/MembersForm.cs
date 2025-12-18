using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using LibraryManagementSystem.Data;

namespace LibraryManagementSystem
{
    public partial class MembersForm : Form
    {
        private int selectedMemberId = 0;

        public MembersForm()
        {
            InitializeComponent();
        }

        private void MembersForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        void LoadMembers()
        {
            string query = "SELECT MemberID, FullName, Phone, Email FROM Members";
            dgvMembers.DataSource = DatabaseHelper.ExecuteSelect(query);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string query = @"
                INSERT INTO Members (FullName, Phone, Email)
                VALUES (@Name, @Phone, @Email)";

            SqlParameter[] p =
            {
                new("@Name", txtFullName.Text),
                new("@Phone", txtPhone.Text),
                new("@Email", txtEmail.Text)
            };

            DatabaseHelper.ExecuteNonQuery(query, p);
            LoadMembers();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMemberId == 0) return;

            string query = @"
                UPDATE Members
                SET FullName=@Name, Phone=@Phone, Email=@Email
                WHERE MemberID=@Id";

            SqlParameter[] p =
            {
                new("@Name", txtFullName.Text),
                new("@Phone", txtPhone.Text),
                new("@Email", txtEmail.Text),
                new("@Id", selectedMemberId)
            };

            DatabaseHelper.ExecuteNonQuery(query, p);
            LoadMembers();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMemberId == 0) return;

            string query = "DELETE FROM Members WHERE MemberID=@Id";
            SqlParameter[] p = { new("@Id", selectedMemberId) };

            DatabaseHelper.ExecuteNonQuery(query, p);
            LoadMembers();
            ClearFields();
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvMembers.Rows[e.RowIndex];
            selectedMemberId = Convert.ToInt32(row.Cells["MemberID"].Value);

            txtFullName.Text = row.Cells["FullName"].Value.ToString();
            txtPhone.Text = row.Cells["Phone"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = dgvMembers.DataSource as DataTable;
            if (dt == null) return;

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
        }

        bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill all fields");
                return false;
            }
            return true;
        }
    }
}
