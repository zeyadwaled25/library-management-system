namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm();
            booksForm.Show();
        }


        private void btnMembers_Click(object sender, EventArgs e)
        {
            MembersForm membersForm = new MembersForm();
            membersForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
