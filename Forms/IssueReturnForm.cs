using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Repositories;

namespace LibraryManagementSystem
{
    public partial class IssueReturnForm : Form
    {
        private readonly BorrowingRepository _repo = new BorrowingRepository();

        public IssueReturnForm()
        {
            InitializeComponent();

            this.Load += IssueReturnForm_Load;
            this.btnIssue.Click += btnIssue_Click;
            this.btnReturn.Click += btnReturn_Click;
        }

        private async void IssueReturnForm_Load(object sender, EventArgs e)
        {
            await LoadIssueData();
            await LoadReturnData();
        }

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabReturn)
            {
                await LoadReturnData();
            }
            else
            {
                await LoadIssueData();
            }
        }

        async Task LoadIssueData()
        {
            var books = await _repo.GetAvailableBooksAsync();
            cmbBooks.DataSource = books;
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "BookID";
            cmbBooks.SelectedIndex = -1;

            var members = await _repo.GetAllMembersAsync();
            cmbMembers.DataSource = members;
            cmbMembers.DisplayMember = "FullName";
            cmbMembers.ValueMember = "MemberID";
            cmbMembers.SelectedIndex = -1;

            dtpReturnDate.MinDate = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today.AddDays(7);
        }

        async Task LoadReturnData()
        {
            var borrowings = await _repo.GetCurrentBorrowingsAsync();
            dgvBorrowings.DataSource = borrowings;

            if (dgvBorrowings.Columns.Contains("BorrowID"))
                dgvBorrowings.Columns["BorrowID"].Visible = false;
        }

        private async void btnIssue_Click(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedIndex == -1 || cmbMembers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book and a member.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int bookId = Convert.ToInt32(cmbBooks.SelectedValue);
                int memberId = Convert.ToInt32(cmbMembers.SelectedValue);
                DateTime returnDate = dtpReturnDate.Value;

                await _repo.IssueBookAsync(bookId, memberId, returnDate);

                MessageBox.Show("Book issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadIssueData();
                cmbBooks.SelectedIndex = -1;
                cmbMembers.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error issuing book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvBorrowings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to return.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int borrowId = Convert.ToInt32(dgvBorrowings.SelectedRows[0].Cells["BorrowID"].Value);

                var confirm = MessageBox.Show("Are you sure you want to return this book?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    await _repo.ReturnBookAsync(borrowId);
                    MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await LoadReturnData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}