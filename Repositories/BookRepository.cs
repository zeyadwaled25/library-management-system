using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Repositories
{
    public class BookRepository
    {
        public async Task<DataTable> GetAllBooksAsync()
        {
            return await Task.Run(() =>
            {
                string query = @"
                    SELECT 
                        B.BookID,
                        B.Title,
                        B.Author,
                        C.CategoryName AS Category,
                        B.CategoryID,
                        B.Quantity
                    FROM Books B
                    INNER JOIN Categories C ON B.CategoryID = C.CategoryID";

                return DatabaseHelper.ExecuteSelect(query);
            });
        }

        public async Task<List<CategoryItem>> GetCategoriesAsync()
        {
            return await Task.Run(() =>
            {
                var list = new List<CategoryItem>();
                string query = "SELECT CategoryID, CategoryName FROM Categories";

                DataTable dt = DatabaseHelper.ExecuteSelect(query);

                foreach (DataRow row in dt.Rows)
                {
                    list.Add(new CategoryItem
                    {
                        ID = Convert.ToInt32(row["CategoryID"]),
                        Name = row["CategoryName"].ToString()
                    });
                }

                return list;
            });
        }

        public async Task AddBookAsync(Book book)
        {
            await Task.Run(() =>
            {
                string query = @"
                    INSERT INTO Books (Title, Author, CategoryID, Quantity)
                    VALUES (@Title, @Author, @CatID, @Qty)";

                SqlParameter[] p =
                {
                    new("@Title", book.Title),
                    new("@Author", book.Author),
                    new("@CatID", book.CategoryID),
                    new("@Qty", book.Quantity)
                };

                DatabaseHelper.ExecuteNonQuery(query, p);
            });
        }

        public async Task UpdateBookAsync(Book book)
        {
            await Task.Run(() =>
            {
                string query = @"
                    UPDATE Books
                    SET 
                        Title = @Title,
                        Author = @Author,
                        CategoryID = @CatID,
                        Quantity = @Qty
                    WHERE BookID = @Id";

                SqlParameter[] p =
                {
                    new("@Title", book.Title),
                    new("@Author", book.Author),
                    new("@CatID", book.CategoryID),
                    new("@Qty", book.Quantity),
                    new("@Id", book.BookID)
                };

                DatabaseHelper.ExecuteNonQuery(query, p);
            });
        }

        public async Task DeleteBookAsync(int id)
        {
            await Task.Run(() =>
            {
                string query = "DELETE FROM Books WHERE BookID = @Id";
                SqlParameter[] p = { new("@Id", id) };

                DatabaseHelper.ExecuteNonQuery(query, p);
            });
        }

        public async Task<int> AddCategoryAsync(string categoryName)
        {
            return await Task.Run(() =>
            {
                string checkQuery = "SELECT CategoryID FROM Categories WHERE CategoryName = @Name";
                SqlParameter[] pCheck = { new("@Name", categoryName) };

                object result = DatabaseHelper.ExecuteScalar(checkQuery, pCheck);

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }

                string insertQuery = "INSERT INTO Categories (CategoryName) VALUES (@Name); SELECT SCOPE_IDENTITY();";
                SqlParameter[] pInsert = { new("@Name", categoryName) };

                object newId = DatabaseHelper.ExecuteScalar(insertQuery, pInsert);
                return Convert.ToInt32(newId);
            });
        }
    }
}