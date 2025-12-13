namespace LibraryManagementSystem
{
    partial class BooksForm
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
            dgvBooks = new DataGridView();
            grpBookDetails = new GroupBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtCategory = new TextBox();
            numQuantity = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            cmbCategory = new ComboBox();
            BookId = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            IsAvailable = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            grpBookDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { BookId, Title, Author, Category, Quantity, IsAvailable });
            dgvBooks.Location = new Point(77, 84);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(803, 188);
            dgvBooks.TabIndex = 0;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // grpBookDetails
            // 
            grpBookDetails.Controls.Add(numQuantity);
            grpBookDetails.Controls.Add(txtCategory);
            grpBookDetails.Controls.Add(txtAuthor);
            grpBookDetails.Controls.Add(txtTitle);
            grpBookDetails.Location = new Point(77, 293);
            grpBookDetails.Name = "grpBookDetails";
            grpBookDetails.Size = new Size(803, 80);
            grpBookDetails.TabIndex = 1;
            grpBookDetails.TabStop = false;
            grpBookDetails.Text = "Book Details";
            grpBookDetails.Enter += grpBookDetails_Enter;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(22, 40);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 27);
            txtTitle.TabIndex = 0;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(242, 40);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(200, 27);
            txtAuthor.TabIndex = 1;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(464, 40);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(150, 27);
            txtCategory.TabIndex = 2;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(635, 40);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(150, 27);
            numQuantity.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(259, 415);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(377, 415);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(497, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(612, 415);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(77, 35);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(280, 27);
            txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(377, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(497, 34);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 8;
            // 
            // BookId
            // 
            BookId.HeaderText = "BookId";
            BookId.MinimumWidth = 6;
            BookId.Name = "BookId";
            BookId.ReadOnly = true;
            BookId.Visible = false;
            BookId.Width = 150;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 175;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.ReadOnly = true;
            Author.Width = 175;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 150;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 125;
            // 
            // IsAvailable
            // 
            IsAvailable.HeaderText = "IsAvailable";
            IsAvailable.MinimumWidth = 6;
            IsAvailable.Name = "IsAvailable";
            IsAvailable.ReadOnly = true;
            IsAvailable.Width = 125;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 503);
            Controls.Add(cmbCategory);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(grpBookDetails);
            Controls.Add(dgvBooks);
            Name = "BooksForm";
            Text = "BooksForm";
            Load += BooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            grpBookDetails.ResumeLayout(false);
            grpBookDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBooks;
        private GroupBox grpBookDetails;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private TextBox numQuantity;
        private TextBox txtCategory;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox cmbCategory;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn IsAvailable;
    }
}