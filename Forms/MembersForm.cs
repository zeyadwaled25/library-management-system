using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

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
                using (SqlConnection con = new SqlConnection(
                    "Data Source=localhost;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT MemberID, FullName, Phone, Email FROM Members", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;
                }
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
                MessageBox.Show("Please fill all fields before adding a member.");
                return;
            }

            string query = "INSERT INTO Members (FullName, Phone, Email) VALUES (@FullName, @Phone, @Email)";

            try
            {
                using (SqlConnection con = new SqlConnection(
                    "Data Source=localhost;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 100).Value = txtFullName.Text;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = txtPhone.Text;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = txtEmail.Text;

                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show("Member added successfully!");
                            LoadMembers();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("No member was added.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding member:\n" + ex.Message);
            }
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (memberId == 0) return;

            string query = "UPDATE Members SET FullName=@FullName, Phone=@Phone, Email=@Email WHERE MemberID=@id";

            try
            {
                using (SqlConnection con = new SqlConnection(
                    "Data Source=localhost;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 100).Value = txtFullName.Text;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = txtPhone.Text;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = txtEmail.Text;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = memberId;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        LoadMembers();
                        ClearFields();
                        MessageBox.Show("Member updated successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating member:\n" + ex.Message);
            }
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (memberId == 0) return;

            string query = "DELETE FROM Members WHERE MemberID=@id";

            try
            {
                using (SqlConnection con = new SqlConnection(
                    "Data Source=localhost;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = memberId;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        LoadMembers();
                        ClearFields();
                        MessageBox.Show("Member deleted successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting member:\n" + ex.Message);
            }
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            memberId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtFullName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
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
