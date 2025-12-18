namespace LibraryManagementSystem
{
    partial class MembersForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvMembers = new DataGridView();
            grpMemberDetails = new GroupBox();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            grpMemberDetails.SuspendLayout();
            SuspendLayout();

            // dgvMembers
            dgvMembers.Location = new Point(20, 60);
            dgvMembers.Size = new Size(760, 240);
            dgvMembers.ReadOnly = true;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.MultiSelect = false;
            dgvMembers.AutoGenerateColumns = true;
            dgvMembers.CellClick += dgvMembers_CellClick;

            // Search
            lblSearch.Text = "Search:";
            lblSearch.Location = new Point(20, 20);

            txtSearch.Location = new Point(80, 17);
            txtSearch.Size = new Size(250, 27);
            txtSearch.TextChanged += txtSearch_TextChanged;

            // grpMemberDetails
            grpMemberDetails.Text = "Member Details";
            grpMemberDetails.Location = new Point(20, 310);
            grpMemberDetails.Size = new Size(760, 90);

            txtFullName.PlaceholderText = "Full Name";
            txtFullName.Location = new Point(20, 40);
            txtFullName.Size = new Size(200, 27);

            txtPhone.PlaceholderText = "Phone";
            txtPhone.Location = new Point(240, 40);
            txtPhone.Size = new Size(150, 27);

            txtEmail.PlaceholderText = "Email";
            txtEmail.Location = new Point(410, 40);
            txtEmail.Size = new Size(200, 27);

            grpMemberDetails.Controls.AddRange(new Control[]
            {
                txtFullName, txtPhone, txtEmail
            });

            // Buttons
            btnAdd.Text = "Add";
            btnAdd.Location = new Point(120, 420);
            btnAdd.Click += btnAdd_Click;

            btnUpdate.Text = "Update";
            btnUpdate.Location = new Point(220, 420);
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Text = "Delete";
            btnDelete.Location = new Point(320, 420);
            btnDelete.Click += btnDelete_Click;

            btnClear.Text = "Clear";
            btnClear.Location = new Point(420, 420);
            btnClear.Click += btnClear_Click;

            // Form
            ClientSize = new Size(800, 480);
            Controls.AddRange(new Control[]
            {
                dgvMembers, grpMemberDetails,
                btnAdd, btnUpdate, btnDelete, btnClear,
                txtSearch, lblSearch
            });

            Text = "Members Management";
            Load += MembersForm_Load;

            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            grpMemberDetails.ResumeLayout(false);
            grpMemberDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMembers;
        private GroupBox grpMemberDetails;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private TextBox txtSearch;
        private Label lblSearch;
    }
}
