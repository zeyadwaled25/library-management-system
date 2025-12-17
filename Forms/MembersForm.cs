using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using LibraryManagementSystem.Data;

namespace LibraryManagementSystem
{
    public partial class MembersForm : Form
    {
        int memberId = 0;

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
            try
            {
                string query = "SELECT MemberID, FullName, Phone, Email FROM Members";
                DataTable dt = DatabaseHelper.ExecuteSelect(query);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members:\n" + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string query =
                "INSERT INTO Members (FullName, Phone, Email) VALUES (@FullName, @Phone, @Email)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@FullName", SqlDbType.NVarChar, 100) { Value = txtFullName.Text },
                new SqlParameter("@Phone", SqlDbType.NVarChar, 20) { Value = txtPhone.Text },
                new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = txtEmail.Text }
            };

            try
            {
                int rows = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rows > 0)
                {
                    MessageBox.Show("Member added successfully!");
                    LoadMembers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding member:\n" + ex.Message);
            }
        }

      
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (memberId == 0)
            {
                MessageBox.Show("Please select a member first.");
                return;
            }

            string query =
                @"UPDATE Members 
                  SET FullName=@FullName, Phone=@Phone, Email=@Email
                  WHERE MemberID=@id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@FullName", SqlDbType.NVarChar, 100) { Value = txtFullName.Text },
                new SqlParameter("@Phone", SqlDbType.NVarChar, 20) { Value = txtPhone.Text },
                new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = txtEmail.Text },
                new SqlParameter("@id", SqlDbType.Int) { Value = memberId }
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                LoadMembers();
                ClearFields();
                MessageBox.Show("Member updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating member:\n" + ex.Message);
            }
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (memberId == 0)
            {
                MessageBox.Show("Please select a member first.");
                return;
            }

            string query = "DELETE FROM Members WHERE MemberID=@id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@id", SqlDbType.Int) { Value = memberId }
            };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                LoadMembers();
                ClearFields();
                MessageBox.Show("Member deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting member:\n" + ex.Message);
            }
        }

     
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            memberId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MemberID"].Value);
            txtFullName.Text = dataGridView1.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
        }

     
        void ClearFields()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            memberId = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
