using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using LibraryManagementSystem.Data;

namespace LibraryManagementSystem
{
    public partial class IssueReturnForm : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True;Encrypt=False";

        public IssueReturnForm()
        {
            InitializeComponent();
            this.Load += IssueReturnForm_Load;
        }

        private void IssueReturnForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadMembers();
            LoadBorrowedBooks();
        }

        void LoadBooks()
        {
            DataTable dt = DatabaseHelper.ExecuteSelect("SELECT BookID, Title FROM Books");
            cmbMembers.DisplayMember = "Title";
            cmbMembers.ValueMember = "BookID";
            cmbMembers.DataSource = dt;
        }

        void LoadMembers()
        {
            DataTable dt = DatabaseHelper.ExecuteSelect("SELECT MemberID, FullName FROM Members");
            cmbBooks.DisplayMember = "FullName";
            cmbBooks.ValueMember = "MemberID";
            cmbBooks.DataSource = dt;
        }

        void LoadBorrowedBooks()
        {
            DataTable dt = DatabaseHelper.ExecuteSelect(
                "SELECT b.BorrowID, bk.Title AS BookTitle, m.FullName AS MemberName, b.BorrowDate " +
                "FROM Borrowings b " +
                "JOIN Books bk ON b.BookID = bk.BookID " +
                "JOIN Members m ON b.MemberID = m.MemberID " +
                "WHERE b.Status = 'Borrowed'");

            dgvBorrowings.DataSource = dt;

            if (dgvBorrowings.Columns.Contains("BorrowID"))
            {
                dgvBorrowings.Columns["BorrowID"].Visible = false;
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (cmbMembers.SelectedValue == null || cmbBooks.SelectedValue == null)
            {
                MessageBox.Show("Please select a book and member.");
                return;
            }

            int bookID = Convert.ToInt32(cmbMembers.SelectedValue);
            int memberID = Convert.ToInt32(cmbBooks.SelectedValue);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddBorrowing", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        cmd.Parameters.AddWithValue("@ExpectedReturnDate", DateTime.Now.AddDays(14));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Book issued successfully.");
                LoadBorrowedBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error issuing book:\n\n" + ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvBorrowings.CurrentRow == null)
            {
                MessageBox.Show("Please select a book to return.");
                return;
            }

            int borrowID = Convert.ToInt32(dgvBorrowings.CurrentRow.Cells["BorrowID"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("ReturnBook", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@BorrowID", borrowID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Book returned successfully.");
                LoadBorrowedBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning book:\n\n" + ex.Message);
            }
        }

        private void issueReturnLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
