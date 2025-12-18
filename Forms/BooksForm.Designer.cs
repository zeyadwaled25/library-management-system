namespace LibraryManagementSystem
{
    partial class BooksForm
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
            lblHeader = new Label();
            panelSearch = new Panel();
            btnSearch = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvBooks = new DataGridView();
            BookId = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            grpBookDetails = new GroupBox();
            lblQuantity = new Label();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            cmbCategory = new ComboBox();
            numQuantity = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            panelButtons = new Panel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            grpBookDetails.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Black;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(900, 55);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Books Management";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(btnSearch);
            panelSearch.Controls.Add(lblSearch);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 55);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(10);
            panelSearch.Size = new Size(900, 55);
            panelSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(390, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(15, 18);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(80, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by Title or Author...";
            txtSearch.Size = new Size(300, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeight = 29;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { BookId, Title, Author, Category, Quantity });
            dgvBooks.Dock = DockStyle.Top;
            dgvBooks.Location = new Point(0, 110);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(900, 260);
            dgvBooks.TabIndex = 2;
            dgvBooks.CellClick += dgvBooks_CellClick;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // BookId
            // 
            BookId.HeaderText = "BookId";
            BookId.MinimumWidth = 6;
            BookId.Name = "BookId";
            BookId.ReadOnly = true;
            BookId.Visible = false;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // grpBookDetails
            // 
            grpBookDetails.Controls.Add(lblQuantity);
            grpBookDetails.Controls.Add(lblCategory);
            grpBookDetails.Controls.Add(lblAuthor);
            grpBookDetails.Controls.Add(lblTitle);
            grpBookDetails.Controls.Add(cmbCategory);
            grpBookDetails.Controls.Add(numQuantity);
            grpBookDetails.Controls.Add(txtAuthor);
            grpBookDetails.Controls.Add(txtTitle);
            grpBookDetails.Location = new Point(0, 376);
            grpBookDetails.Name = "grpBookDetails";
            grpBookDetails.Padding = new Padding(15);
            grpBookDetails.Size = new Size(900, 100);
            grpBookDetails.TabIndex = 3;
            grpBookDetails.TabStop = false;
            grpBookDetails.Text = "Book Details";
            grpBookDetails.Enter += grpBookDetails_Enter;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(676, 23);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 20);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(460, 23);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 20);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(240, 23);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(57, 20);
            lblAuthor.TabIndex = 5;
            lblAuthor.Text = "Author:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Title:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(460, 45);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 28);
            cmbCategory.TabIndex = 2;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(676, 46);
            numQuantity.Name = "numQuantity";
            numQuantity.PlaceholderText = "Qty";
            numQuantity.Size = new Size(100, 27);
            numQuantity.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(240, 46);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PlaceholderText = "Author Name";
            txtAuthor.Size = new Size(200, 27);
            txtAuthor.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(20, 46);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Book Title";
            txtTitle.Size = new Size(200, 27);
            txtTitle.TabIndex = 0;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnClear);
            panelButtons.Location = new Point(0, 476);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(10);
            panelButtons.Size = new Size(900, 73);
            panelButtons.TabIndex = 4;
            // 
            // btnAdd
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
            // btnUpdate
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
            // btnDelete
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
            // btnClear
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
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(panelButtons);
            Controls.Add(grpBookDetails);
            Controls.Add(dgvBooks);
            Controls.Add(panelSearch);
            Controls.Add(lblHeader);
            Name = "BooksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books Management";
            Load += BooksForm_Load;
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            grpBookDetails.ResumeLayout(false);
            grpBookDetails.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeader;
        private Panel panelSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvBooks;
        private GroupBox grpBookDetails;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox numQuantity;
        private ComboBox cmbCategory;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblCategory;
        private Label lblQuantity;
        private Panel panelButtons;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Quantity;
    }
}