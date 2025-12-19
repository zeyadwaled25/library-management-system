namespace LibraryManagementSystem
{
    partial class IssueReturnForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            issueReturnLabel = new Label();
            grpIssue = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnIssue = new Button();
            dtExpectedReturn = new DateTimePicker();
            cmbBooks = new ComboBox();
            cmbMembers = new ComboBox();
            grpReturn = new GroupBox();
            btnReturn = new Button();
            dgvBorrowings = new DataGridView();
            grpIssue.SuspendLayout();
            grpReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowings).BeginInit();
            SuspendLayout();
            // 
            // issueReturnLabel
            // 
            issueReturnLabel.AutoSize = true;
            issueReturnLabel.BackColor = Color.Transparent;
            issueReturnLabel.Font = new Font("Segoe Print", 20F, FontStyle.Bold);
            issueReturnLabel.ForeColor = Color.Black;
            issueReturnLabel.Location = new Point(344, 20);
            issueReturnLabel.Name = "issueReturnLabel";
            issueReturnLabel.Size = new Size(382, 61);
            issueReturnLabel.TabIndex = 3;
            issueReturnLabel.Text = "Issue / Return Books";
            issueReturnLabel.TextAlign = ContentAlignment.MiddleCenter;
            issueReturnLabel.Click += issueReturnLabel_Click;
            // 
            // grpIssue
            // 
            grpIssue.Controls.Add(label3);
            grpIssue.Controls.Add(label2);
            grpIssue.Controls.Add(label1);
            grpIssue.Controls.Add(btnIssue);
            grpIssue.Controls.Add(dtExpectedReturn);
            grpIssue.Controls.Add(cmbBooks);
            grpIssue.Controls.Add(cmbMembers);
            grpIssue.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic);
            grpIssue.Location = new Point(27, 95);
            grpIssue.Name = "grpIssue";
            grpIssue.Size = new Size(892, 95);
            grpIssue.TabIndex = 4;
            grpIssue.TabStop = false;
            grpIssue.Text = "Issue Book";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 20);
            label3.Name = "label3";
            label3.Size = new Size(117, 26);
            label3.TabIndex = 6;
            label3.Text = "Return Date :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 17);
            label2.Name = "label2";
            label2.Size = new Size(84, 26);
            label2.TabIndex = 5;
            label2.Text = "Member :";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 17);
            label1.Name = "label1";
            label1.Size = new Size(58, 26);
            label1.TabIndex = 4;
            label1.Text = "Book :";
            // 
            // btnIssue
            // 
            btnIssue.BackColor = Color.BurlyWood;
            btnIssue.Location = new Point(792, 49);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(94, 33);
            btnIssue.TabIndex = 3;
            btnIssue.Text = "Issue Book";
            btnIssue.UseVisualStyleBackColor = false;
            btnIssue.Click += btnIssueBook_Click;
            // 
            // dtExpectedReturn
            // 
            dtExpectedReturn.CalendarMonthBackground = Color.BurlyWood;
            dtExpectedReturn.CalendarTrailingForeColor = Color.BurlyWood;
            dtExpectedReturn.Location = new Point(520, 49);
            dtExpectedReturn.Name = "dtExpectedReturn";
            dtExpectedReturn.Size = new Size(250, 34);
            dtExpectedReturn.TabIndex = 2;
            // 
            // cmbBooks
            // 
            cmbBooks.BackColor = Color.BurlyWood;
            cmbBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(345, 48);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(151, 34);
            cmbBooks.TabIndex = 1;
            // 
            // cmbMembers
            // 
            cmbMembers.BackColor = Color.BurlyWood;
            cmbMembers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMembers.FormattingEnabled = true;
            cmbMembers.Location = new Point(162, 48);
            cmbMembers.Name = "cmbMembers";
            cmbMembers.Size = new Size(151, 34);
            cmbMembers.TabIndex = 0;
            // 
            // grpReturn
            // 
            grpReturn.Controls.Add(btnReturn);
            grpReturn.Controls.Add(dgvBorrowings);
            grpReturn.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic);
            grpReturn.Location = new Point(27, 196);
            grpReturn.Name = "grpReturn";
            grpReturn.Size = new Size(892, 282);
            grpReturn.TabIndex = 5;
            grpReturn.TabStop = false;
            grpReturn.Text = "Return Book";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.BurlyWood;
            btnReturn.Location = new Point(22, 241);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(111, 35);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return Book";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // dgvBorrowings
            // 
            dgvBorrowings.BackgroundColor = Color.Linen;
            dgvBorrowings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowings.Location = new Point(22, 41);
            dgvBorrowings.MultiSelect = false;
            dgvBorrowings.Name = "dgvBorrowings";
            dgvBorrowings.ReadOnly = true;
            dgvBorrowings.RowHeadersWidth = 51;
            dgvBorrowings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowings.Size = new Size(836, 188);
            dgvBorrowings.TabIndex = 0;
            // 
            // IssueReturnForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = Properties.Resources.words_unspoken;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 503);
            Controls.Add(grpReturn);
            Controls.Add(grpIssue);
            Controls.Add(issueReturnLabel);
            Name = "IssueReturnForm";
            Text = "IssueReturnForm";
            Load += IssueReturnForm_Load;
            grpIssue.ResumeLayout(false);
            grpIssue.PerformLayout();
            grpReturn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label issueReturnLabel;
        private GroupBox grpIssue;
        private Button btnIssue;
        private DateTimePicker dtExpectedReturn;
        private ComboBox cmbBooks;
        private ComboBox cmbMembers;
        private GroupBox grpReturn;
        private DataGridView dgvBorrowings;
        private Button btnReturn;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}