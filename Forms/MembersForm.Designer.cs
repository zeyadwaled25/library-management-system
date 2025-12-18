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
            lblHeader = new Label();
            panelSearch = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvMembers = new DataGridView();
            grpMemberDetails = new GroupBox();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            panelButtons = new Panel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            grpMemberDetails.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Black;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(900, 55);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "Members Management";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            panelSearch.Controls.Add(lblSearch);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 55);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(10);
            panelSearch.Size = new Size(900, 55);
            panelSearch.TabIndex = 3;
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(15, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            txtSearch.Location = new Point(80, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name or phone...";
            txtSearch.Size = new Size(300, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ColumnHeadersHeight = 29;
            dgvMembers.Dock = DockStyle.Top;
            dgvMembers.Location = new Point(0, 110);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(900, 260);
            dgvMembers.TabIndex = 2;
            dgvMembers.CellClick += dgvMembers_CellClick;
            // 
            grpMemberDetails.Controls.Add(txtFullName);
            grpMemberDetails.Controls.Add(txtPhone);
            grpMemberDetails.Controls.Add(txtEmail);
            grpMemberDetails.Location = new Point(0, 376);
            grpMemberDetails.Name = "grpMemberDetails";
            grpMemberDetails.Padding = new Padding(15);
            grpMemberDetails.Size = new Size(900, 100);
            grpMemberDetails.TabIndex = 1;
            grpMemberDetails.TabStop = false;
            grpMemberDetails.Text = "Member Details";
            // 
            txtFullName.Location = new Point(20, 45);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Full Name";
            txtFullName.Size = new Size(220, 27);
            txtFullName.TabIndex = 0;
            // 
            txtPhone.Location = new Point(260, 45);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone";
            txtPhone.Size = new Size(160, 27);
            txtPhone.TabIndex = 1;
            // 
            txtEmail.Location = new Point(440, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(260, 27);
            txtEmail.TabIndex = 2;
            // 
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnClear);
            panelButtons.Location = new Point(0, 476);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(900, 73);
            panelButtons.TabIndex = 0;
            // 
            btnAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(220, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 123, 255);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(340, 18);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(460, 18);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(580, 18);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 35);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            ClientSize = new Size(900, 550);
            Controls.Add(panelButtons);
            Controls.Add(grpMemberDetails);
            Controls.Add(dgvMembers);
            Controls.Add(panelSearch);
            Controls.Add(lblHeader);
            Name = "MembersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Members";
            Load += MembersForm_Load;
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            grpMemberDetails.ResumeLayout(false);
            grpMemberDetails.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeader;
        private Panel panelSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView dgvMembers;
        private GroupBox grpMemberDetails;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Panel panelButtons;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}
