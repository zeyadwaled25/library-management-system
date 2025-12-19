using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories;

namespace LibraryManagementSystem
{
    public partial class BooksForm : Form
    {
        private readonly BookRepository _repo = new();
        private int selectedBookId = 0;

        public BooksForm()
        {
            InitializeComponent();

            this.Load += BooksForm_Load;
            this.dgvBooks.CellClick += dgvBooks_CellClick;
            this.btnAdd.Click += btnAdd_Click;
            this.btnUpdate.Click += btnUpdate_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.btnClear.Click += btnClear_Click;
            this.txtSearch.TextChanged += txtSearch_TextChanged;
            this.cmbFilterCategory.SelectedIndexChanged += cmbFilterCategory_SelectedIndexChanged;
        }

        private async void BooksForm_Load(object sender, EventArgs e)
        {
            SetupGrid();
            await LoadCategoriesAsync();
            await LoadBooksAsync();
            UpdateButtonsState();
        }

        void SetupGrid()
        {
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.Columns.Clear();

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "BookID",
                Visible = false
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Title",
                HeaderText = "Title",
                DataPropertyName = "Title"
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Author",
                HeaderText = "Author",
                DataPropertyName = "Author"
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Category",
                HeaderText = "Category",
                DataPropertyName = "Category"
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "Quantity",
                DataPropertyName = "Quantity"
            });
        }

        async Task LoadBooksAsync()
        {
            var books = await _repo.GetAllBooksAsync();
            dgvBooks.DataSource = books;
            ApplySearch();
        }

        async Task LoadCategoriesAsync()
        {
            var categories = await _repo.GetCategoriesAsync();

            cmbCategory.DataSource = new BindingSource(categories, null);
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "ID";
            cmbCategory.SelectedIndex = -1;

            var filterList = new List<CategoryItem>(categories);
            filterList.Insert(0, new CategoryItem { ID = 0, Name = "All Categories" });

            cmbFilterCategory.DataSource = filterList;
            cmbFilterCategory.DisplayMember = "Name";
            cmbFilterCategory.ValueMember = "ID";
            cmbFilterCategory.SelectedIndex = 0;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            int categoryId = await GetOrCreateCategoryId(cmbCategory.Text.Trim());

            var book = new Book
            {
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                CategoryID = categoryId,
                Quantity = int.Parse(numQuantity.Text)
            };

            await _repo.AddBookAsync(book);
            await LoadBooksAsync();

            if (categoryId != (int?)cmbCategory.SelectedValue)
            {
                await LoadCategoriesAsync();
            }

            ClearFields();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBookId == 0) return;
            if (!ValidateInputs()) return;

            int categoryId = await GetOrCreateCategoryId(cmbCategory.Text.Trim());

            var book = new Book
            {
                BookID = selectedBookId,
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                CategoryID = categoryId,
                Quantity = int.Parse(numQuantity.Text)
            };

            await _repo.UpdateBookAsync(book);
            await LoadBooksAsync();

            if (cmbCategory.SelectedValue == null || categoryId != (int)cmbCategory.SelectedValue)
            {
                await LoadCategoriesAsync();
            }

            ClearFields();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBookId == 0) return;

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this book?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            await _repo.DeleteBookAsync(selectedBookId);
            await LoadBooksAsync();
            ClearFields();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvBooks.Rows.Count) return;

            try
            {
                var row = dgvBooks.Rows[e.RowIndex];

                if (dgvBooks.Columns.Contains("ID") && row.Cells["ID"].Value != null)
                {
                    if (int.TryParse(row.Cells["ID"].Value.ToString(), out int id))
                    {
                        selectedBookId = id;
                    }

                    txtTitle.Text = row.Cells["Title"].Value?.ToString() ?? "";
                    txtAuthor.Text = row.Cells["Author"].Value?.ToString() ?? "";
                    numQuantity.Text = row.Cells["Quantity"].Value?.ToString() ?? "0";

                    string categoryName = row.Cells["Category"].Value?.ToString();
                    cmbCategory.Text = categoryName;

                    UpdateButtonsState();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplySearch();
        }

        private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySearch();
        }

        void ApplySearch()
        {
            if (dgvBooks.DataSource is not DataTable dt) return;

            string search = txtSearch.Text.Replace("'", "''");
            string filter = "";

            if (!string.IsNullOrWhiteSpace(search))
                filter = $"Title LIKE '%{search}%' OR Author LIKE '%{search}%'";

            if (cmbFilterCategory.SelectedIndex > 0)
            {
                string cat = cmbFilterCategory.Text.Replace("'", "''");
                string catFilter = $"Category LIKE '{cat}'";
                filter = filter == "" ? catFilter : $"({filter}) AND {catFilter}";
            }

            dt.DefaultView.RowFilter = filter;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        void ClearFields()
        {
            selectedBookId = 0;
            txtTitle.Clear();
            txtAuthor.Clear();
            numQuantity.Clear();
            cmbCategory.SelectedIndex = -1;
            dgvBooks.ClearSelection();
            UpdateButtonsState();
            txtTitle.Focus();
        }

        void UpdateButtonsState()
        {
            bool hasSelection = selectedBookId != 0;
            btnUpdate.Enabled = hasSelection;
            btnDelete.Enabled = hasSelection;
            btnAdd.Enabled = !hasSelection;
        }

        bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text) ||
                !int.TryParse(numQuantity.Text, out _))
            {
                MessageBox.Show("Please fill all fields correctly",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private async Task<int> GetOrCreateCategoryId(string categoryName)
        {
            foreach (var item in cmbCategory.Items)
            {
                var catItem = item as CategoryItem;
                if (catItem != null && catItem.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase))
                {
                    return catItem.ID;
                }
            }

            return await _repo.AddCategoryAsync(categoryName);
        }
    }
}