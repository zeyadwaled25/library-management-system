using System.Data;
using Microsoft.Data.SqlClient;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Repositories
{
    public class BookRepository
    {
        public DataTable GetAll()
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
        }

        public DataTable GetCategories()
        {
            string query = "SELECT CategoryID, CategoryName FROM Categories";
            return DatabaseHelper.ExecuteSelect(query);
        }

        public void Add(Book book)
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
        }

        public void Update(Book book)
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
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Books WHERE BookID = @Id";
            SqlParameter[] p = { new("@Id", id) };

            DatabaseHelper.ExecuteNonQuery(query, p);
        }
    }
}
