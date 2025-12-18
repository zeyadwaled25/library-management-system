using System;
using System.Data;
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
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadCategories();
            LoadBooks();
            UpdateButtonsState();
        }

        void SetupGrid()
        {
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.Columns.Clear();

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "BookID",
                Visible = false
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Title",
                DataPropertyName = "Title"
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Author",
                DataPropertyName = "Author"
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Category",
                DataPropertyName = "Category"
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                DataPropertyName = "Quantity"
            });
        }

        void LoadBooks()
        {
            dgvBooks.DataSource = _repo.GetAll();
        }

        void LoadCategories()
        {
            DataTable dt = _repo.GetCategories();

            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            _repo.Add(new Book
            {
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                CategoryID = (int)cmbCategory.SelectedValue,
                Quantity = int.Parse(numQuantity.Text)
            });

            LoadBooks();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBookId == 0) return;

            _repo.Update(new Book
            {
                BookID = selectedBookId,
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                CategoryID = (int)cmbCategory.SelectedValue,
                Quantity = int.Parse(numQuantity.Text)
            });

            LoadBooks();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBookId == 0) return;

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this book?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            _repo.Delete(selectedBookId);
            LoadBooks();
            ClearFields();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvBooks.Rows[e.RowIndex];

            selectedBookId = Convert.ToInt32(row.Cells["ID"].Value);
            txtTitle.Text = row.Cells["Title"].Value.ToString();
            txtAuthor.Text = row.Cells["Author"].Value.ToString();
            numQuantity.Text = row.Cells["Quantity"].Value.ToString();
            cmbCategory.Text = row.Cells["Category"].Value.ToString();

            UpdateButtonsState();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplySearch();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
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

            if (cmbCategory.SelectedIndex != -1)
            {
                string cat = cmbCategory.Text.Replace("'", "''");
                filter += (filter == "" ? "" : " AND ") + $"Category LIKE '{cat}%'";
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
                cmbCategory.SelectedIndex == -1 ||
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
    }
}
