namespace LibraryManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnBooks = new Button();
            btnMembers = new Button();
            btnIssue = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 50);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(151, 129);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(141, 29);
            btnBooks.TabIndex = 1;
            btnBooks.Text = "Manage Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnMembers
            // 
            btnMembers.Location = new Point(151, 176);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(150, 29);
            btnMembers.TabIndex = 2;
            btnMembers.Text = "Manage Members";
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnIssue
            // 
            btnIssue.Location = new Point(151, 223);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(166, 29);
            btnIssue.TabIndex = 3;
            btnIssue.Text = "Issue / Return Books";
            btnIssue.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(btnIssue);
            Controls.Add(btnMembers);
            Controls.Add(label1);
            Controls.Add(btnBooks);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMembers;
        private Button btnIssue;
        private Button btnBooks;
    }
}
