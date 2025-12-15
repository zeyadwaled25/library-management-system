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
            cmbMembers = new ComboBox();
            cmbBooks = new ComboBox();
            dtExpectedReturn = new DateTimePicker();
            btnIssue = new Button();
            grpReturn = new GroupBox();
            dgvBorrowings = new DataGridView();
            btnReturn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grpIssue.SuspendLayout();
            grpReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowings).BeginInit();
            SuspendLayout();
            // 
            // issueReturnLabel
            // 
            issueReturnLabel.AutoSize = true;
            issueReturnLabel.Location = new Point(400, 40);
            issueReturnLabel.Name = "issueReturnLabel";
            issueReturnLabel.Size = new Size(142, 20);
            issueReturnLabel.TabIndex = 3;
            issueReturnLabel.Text = "Issue / Return Books";
            issueReturnLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            grpIssue.Location = new Point(27, 80);
            grpIssue.Name = "grpIssue";
            grpIssue.Size = new Size(732, 95);
            grpIssue.TabIndex = 4;
            grpIssue.TabStop = false;
            grpIssue.Text = "Issue Book";
            // 
            // cmbMembers
            // 
            cmbMembers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMembers.FormattingEnabled = true;
            cmbMembers.Location = new Point(22, 49);
            cmbMembers.Name = "cmbMembers";
            cmbMembers.Size = new Size(151, 28);
            cmbMembers.TabIndex = 0;
            // 
            // cmbBooks
            // 
            cmbBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(179, 49);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(151, 28);
            cmbBooks.TabIndex = 1;
            // 
            // dtExpectedReturn
            // 
            dtExpectedReturn.Location = new Point(336, 50);
            dtExpectedReturn.Name = "dtExpectedReturn";
            dtExpectedReturn.Size = new Size(250, 27);
            dtExpectedReturn.TabIndex = 2;
            // 
            // btnIssue
            // 
            btnIssue.Location = new Point(592, 48);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(94, 29);
            btnIssue.TabIndex = 3;
            btnIssue.Text = "Issue Book";
            btnIssue.UseVisualStyleBackColor = true;
            // 
            // grpReturn
            // 
            grpReturn.Controls.Add(btnReturn);
            grpReturn.Controls.Add(dgvBorrowings);
            grpReturn.Location = new Point(27, 196);
            grpReturn.Name = "grpReturn";
            grpReturn.Size = new Size(892, 282);
            grpReturn.TabIndex = 5;
            grpReturn.TabStop = false;
            grpReturn.Text = "Return Book";
            // 
            // dgvBorrowings
            // 
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
            // btnReturn
            // 
            btnReturn.Location = new Point(22, 241);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(111, 29);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return Book";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Book :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 26);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Member :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 27);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 6;
            label3.Text = "Return Date :";
            // 
            // IssueReturnForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 503);
            Controls.Add(grpReturn);
            Controls.Add(grpIssue);
            Controls.Add(issueReturnLabel);
            Name = "IssueReturnForm";
            Text = "IssueReturnForm";
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