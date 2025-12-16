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
        private readonly BookRepository _repository;
        private int _selectedBookId = 0;

        public BooksForm()
        {
            InitializeComponent();
            _repository = new BookRepository();

            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);
            this.cmbCategory.SelectedIndexChanged += new EventHandler(this.cmbCategory_SelectedIndexChanged);
            this.dgvBooks.CellClick += new DataGridViewCellEventHandler(this.dgvBooks_CellClick);
        }

        private async void BooksForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvBooks.AutoGenerateColumns = false;

                if (dgvBooks.Columns["BookId"] != null) dgvBooks.Columns["BookId"].DataPropertyName = "BookID";
                if (dgvBooks.Columns["Title"] != null) dgvBooks.Columns["Title"].DataPropertyName = "Title";
                if (dgvBooks.Columns["Author"] != null) dgvBooks.Columns["Author"].DataPropertyName = "Author";
                if (dgvBooks.Columns["Category"] != null) dgvBooks.Columns["Category"].DataPropertyName = "Category";
                if (dgvBooks.Columns["Quantity"] != null) dgvBooks.Columns["Quantity"].DataPropertyName = "Quantity";

                var categories = await _repository.GetCategoriesAsync();

                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "ID";
                cmbCategory.SelectedIndex = -1;

                await RefreshBooksGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter Title and select Category.");
                return;
            }

            var newBook = new Book
            {
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                Publisher = null,
                Price = 0,
                CategoryID = (int)cmbCategory.SelectedValue,
                Quantity = int.TryParse(numQuantity.Text, out int q) ? q : 0
            };

            try
            {
                btnAdd.Enabled = false;
                await _repository.AddBookAsync(newBook);
                MessageBox.Show("Saved Successfully!");
                ClearFields();
                await RefreshBooksGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnAdd.Enabled = true;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedBookId == 0)
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }

            var bookToUpdate = new Book
            {
                BookID = _selectedBookId,
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                CategoryID = (int)cmbCategory.SelectedValue,
                Quantity = int.TryParse(numQuantity.Text, out int q) ? q : 0
            };

            try
            {
                btnUpdate.Enabled = false;
                await _repository.UpdateBookAsync(bookToUpdate);
                MessageBox.Show("Updated Successfully!");
                ClearFields();
                await RefreshBooksGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnUpdate.Enabled = true;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedBookId == 0)
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            try
            {
                btnDelete.Enabled = false;
                await _repository.DeleteBookAsync(_selectedBookId);
                MessageBox.Show("Deleted Successfully!");
                ClearFields();
                await RefreshBooksGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnDelete.Enabled = true;
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];

                if (row.Cells["BookId"].Value != null && row.Cells["BookId"].Value != DBNull.Value)
                {
                    _selectedBookId = Convert.ToInt32(row.Cells["BookId"].Value);
                }

                txtTitle.Text = row.Cells["Title"].Value?.ToString();
                txtAuthor.Text = row.Cells["Author"].Value?.ToString();
                numQuantity.Text = row.Cells["Quantity"].Value?.ToString();

                string categoryName = row.Cells["Category"].Value?.ToString();
                cmbCategory.Text = categoryName;

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtSearch.Clear();
            cmbCategory.SelectedIndex = -1;
            ApplySearch();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplySearch();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySearch();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplySearch();
        }

        private void ApplySearch()
        {
            var dt = dgvBooks.DataSource as DataTable;
            if (dt == null) return;

            string textSearch = txtSearch.Text.Trim();

            string selectedCategory = "";
            if (cmbCategory.SelectedIndex != -1 && cmbCategory.SelectedItem != null)
            {
                try
                {
                    dynamic categoryItem = cmbCategory.SelectedItem;
                    selectedCategory = categoryItem.Name;
                }
                catch
                {
                    selectedCategory = cmbCategory.Text;
                }
            }

            List<string> filters = new List<string>();

            if (!string.IsNullOrEmpty(textSearch))
            {
                textSearch = textSearch.Replace("'", "''");
                filters.Add(string.Format("(Title LIKE '%{0}%' OR Author LIKE '%{0}%')", textSearch));
            }

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                filters.Add(string.Format("Category LIKE '{0}%'", selectedCategory));
            }

            if (filters.Count > 0)
            {
                dt.DefaultView.RowFilter = string.Join(" AND ", filters);
            }
            else
            {
                dt.DefaultView.RowFilter = string.Empty;
            }
        }

        private async Task RefreshBooksGrid()
        {
            var dt = await _repository.GetAllBooksAsync();
            dgvBooks.DataSource = dt;
            ApplySearch();
        }

        private void ClearFields()
        {
            _selectedBookId = 0;
            txtTitle.Clear();
            txtAuthor.Clear();
            numQuantity.Clear();
            cmbCategory.SelectedIndex = -1;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtTitle.Focus();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void grpBookDetails_Enter(object sender, EventArgs e) { }
        private void txtTitle_TextChanged(object sender, EventArgs e) { }
    }
}