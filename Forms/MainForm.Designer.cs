namespace LibraryManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            mainLabel = new Label();
            btnBooks = new Button();
            btnMembers = new Button();
            btnIssue = new Button();
            headerPanel.SuspendLayout();
            SuspendLayout();
            
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(51, 51, 76);
            headerPanel.Controls.Add(mainLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(800, 80);
            headerPanel.TabIndex = 0;
            
            // 
            // mainLabel
            // 
            mainLabel.Dock = DockStyle.Fill;
            mainLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            mainLabel.ForeColor = Color.White;
            mainLabel.Location = new Point(0, 0);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(800, 80);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "Library Management System";
            mainLabel.TextAlign = ContentAlignment.MiddleCenter;
            
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.FromArgb(26, 188, 156);
            btnBooks.Cursor = Cursors.Hand;
            btnBooks.FlatAppearance.BorderSize = 0;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnBooks.ForeColor = Color.White;
            btnBooks.Location = new Point(250, 150);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(300, 60);
            btnBooks.TabIndex = 1;
            btnBooks.Text = "Manage Books";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            
            // 
            // btnMembers
            // 
            btnMembers.BackColor = Color.FromArgb(52, 152, 219);
            btnMembers.Cursor = Cursors.Hand;
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnMembers.ForeColor = Color.White;
            btnMembers.Location = new Point(250, 230);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(300, 60);
            btnMembers.TabIndex = 2;
            btnMembers.Text = "Manage Members";
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            
            // 
            // btnIssue
            // 
            btnIssue.BackColor = Color.FromArgb(243, 156, 18);
            btnIssue.Cursor = Cursors.Hand;
            btnIssue.FlatAppearance.BorderSize = 0;
            btnIssue.FlatStyle = FlatStyle.Flat;
            btnIssue.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnIssue.ForeColor = Color.White;
            btnIssue.Location = new Point(250, 310);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(300, 60);
            btnIssue.TabIndex = 3;
            btnIssue.Text = "Issue / Return Books";
            btnIssue.UseVisualStyleBackColor = false;
            btnIssue.Click += btnIssue_Click;
            
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(800, 450);
            Controls.Add(btnIssue);
            Controls.Add(btnMembers);
            Controls.Add(btnBooks);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library System Dashboard";
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label mainLabel;
        private Button btnBooks;
        private Button btnMembers;
        private Button btnIssue;

    }
}