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
            mainLabel = new Label();
            btnBooks = new Button();
            btnMembers = new Button();
            btnIssue = new Button();
            SuspendLayout();
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.BackColor = Color.Transparent;
            mainLabel.Font = new Font("Segoe Print", 16.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            mainLabel.Location = new Point(182, 22);
            mainLabel.Margin = new Padding(0);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(447, 51);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "Library Management System";
            mainLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.SeaShell;
            btnBooks.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic);
            btnBooks.Location = new Point(231, 148);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(381, 41);
            btnBooks.TabIndex = 1;
            btnBooks.Text = "Manage Books";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.SeaShell;
            btnMembers.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic);
            btnMembers.Location = new Point(231, 222);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(381, 38);
            btnMembers.TabIndex = 2;
            btnMembers.Text = "Manage Members";
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnIssue
            // 
            btnIssue.BackColor = Color.SeaShell;
            btnIssue.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic);
            btnIssue.Location = new Point(231, 297);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(381, 37);
            btnIssue.TabIndex = 3;
            btnIssue.Text = "Issue / Return Books";
            btnIssue.UseVisualStyleBackColor = false;
            btnIssue.Click += btnIssue_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download1;
            ClientSize = new Size(782, 453);
            Controls.Add(btnIssue);
            Controls.Add(btnMembers);
            Controls.Add(mainLabel);
            Controls.Add(btnBooks);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainLabel;
        private Button btnMembers;
        private Button btnIssue;
        private Button btnBooks;
    }
}
