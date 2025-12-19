namespace LibraryManagementSystem
{
    partial class IssueReturnForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            lblHeader = new Label();
            tabControl1 = new TabControl();
            tabIssue = new TabPage();
            btnIssue = new Button();
            dtpReturnDate = new DateTimePicker();
            lblReturnDate = new Label();
            cmbMembers = new ComboBox();
            lblMember = new Label();
            cmbBooks = new ComboBox();
            lblBook = new Label();
            tabReturn = new TabPage();
            btnReturn = new Button();
            dgvBorrowings = new DataGridView();
            headerPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            tabIssue.SuspendLayout();
            tabReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowings).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(51, 51, 76);
            headerPanel.Controls.Add(lblHeader);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(900, 60);
            headerPanel.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.WhiteSmoke;
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Black;
            lblHeader.ImageKey = "(none)";
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(900, 60);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Issue /Return Management";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabIssue);
            tabControl1.Controls.Add(tabReturn);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(0, 60);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(900, 440);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabIssue
            // 
            tabIssue.BackColor = Color.Transparent;
            tabIssue.Controls.Add(btnIssue);
            tabIssue.Controls.Add(dtpReturnDate);
            tabIssue.Controls.Add(lblReturnDate);
            tabIssue.Controls.Add(cmbMembers);
            tabIssue.Controls.Add(lblMember);
            tabIssue.Controls.Add(cmbBooks);
            tabIssue.Controls.Add(lblBook);
            tabIssue.Location = new Point(4, 32);
            tabIssue.Name = "tabIssue";
            tabIssue.Padding = new Padding(3);
            tabIssue.Size = new Size(892, 404);
            tabIssue.TabIndex = 0;
            tabIssue.Text = "Issue Book";
            // 
            // btnIssue
            // 
            btnIssue.BackColor = Color.FromArgb(40, 167, 69);
            btnIssue.FlatStyle = FlatStyle.Flat;
            btnIssue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIssue.ForeColor = Color.White;
            btnIssue.Location = new Point(364, 259);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(200, 45);
            btnIssue.TabIndex = 6;
            btnIssue.Text = "Confirm Issue";
            btnIssue.UseVisualStyleBackColor = false;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(364, 179);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(300, 30);
            dtpReturnDate.TabIndex = 5;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Segoe UI", 11F);
            lblReturnDate.Location = new Point(214, 184);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(115, 25);
            lblReturnDate.TabIndex = 4;
            lblReturnDate.Text = "Return Date:";
            // 
            // cmbMembers
            // 
            cmbMembers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMembers.FormattingEnabled = true;
            cmbMembers.Location = new Point(364, 119);
            cmbMembers.Name = "cmbMembers";
            cmbMembers.Size = new Size(300, 31);
            cmbMembers.TabIndex = 3;
            // 
            // lblMember
            // 
            lblMember.AutoSize = true;
            lblMember.Font = new Font("Segoe UI", 11F);
            lblMember.Location = new Point(214, 122);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(87, 25);
            lblMember.TabIndex = 2;
            lblMember.Text = "Member:";
            // 
            // cmbBooks
            // 
            cmbBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(364, 59);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(300, 31);
            cmbBooks.TabIndex = 1;
            // 
            // lblBook
            // 
            lblBook.AutoSize = true;
            lblBook.Font = new Font("Segoe UI", 11F);
            lblBook.Location = new Point(214, 62);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(58, 25);
            lblBook.TabIndex = 0;
            lblBook.Text = "Book:";
            // 
            // tabReturn
            // 
            tabReturn.Controls.Add(btnReturn);
            tabReturn.Controls.Add(dgvBorrowings);
            tabReturn.Location = new Point(4, 32);
            tabReturn.Name = "tabReturn";
            tabReturn.Padding = new Padding(3);
            tabReturn.Size = new Size(892, 404);
            tabReturn.TabIndex = 1;
            tabReturn.Text = "Return Book";
            tabReturn.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            btnReturn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReturn.BackColor = Color.FromArgb(220, 53, 69);
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(350, 330);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(200, 45);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return Selected";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // dgvBorrowings
            // 
            dgvBorrowings.AllowUserToAddRows = false;
            dgvBorrowings.AllowUserToDeleteRows = false;
            dgvBorrowings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowings.Dock = DockStyle.Top;
            dgvBorrowings.Location = new Point(3, 3);
            dgvBorrowings.MultiSelect = false;
            dgvBorrowings.Name = "dgvBorrowings";
            dgvBorrowings.ReadOnly = true;
            dgvBorrowings.RowHeadersWidth = 51;
            dgvBorrowings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowings.Size = new Size(886, 300);
            dgvBorrowings.TabIndex = 0;
            // 
            // IssueReturnForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(tabControl1);
            Controls.Add(headerPanel);
            Name = "IssueReturnForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Issue & Return";
            headerPanel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabIssue.ResumeLayout(false);
            tabIssue.PerformLayout();
            tabReturn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label lblHeader;
        private TabControl tabControl1;
        private TabPage tabIssue;
        private TabPage tabReturn;
        private ComboBox cmbBooks;
        private Label lblBook;
        private ComboBox cmbMembers;
        private Label lblMember;
        private DateTimePicker dtpReturnDate;
        private Label lblReturnDate;
        private Button btnIssue;
        private DataGridView dgvBorrowings;
        private Button btnReturn;
    }
}