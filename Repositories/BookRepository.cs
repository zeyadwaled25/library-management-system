using System;
using System.Collections.Generic;
using System.Configuration; 
using System.Data;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using Microsoft.Data.SqlClient;

namespace LibraryManagementSystem.Repositories
{
    public class BookRepository
    {
        private readonly string _connectionString;

        public BookRepository()
        {

            _connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
        }

        public async Task<List<CategoryItem>> GetCategoriesAsync()
        {
            var list = new List<CategoryItem>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "SELECT CategoryID, CategoryName FROM Categories";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    await con.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            list.Add(new CategoryItem
                            {
                                ID = (int)reader["CategoryID"],
                                Name = reader["CategoryName"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public async Task AddBookAsync(Book book)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Books (Title, Author, CategoryID, Quantity) 
                                 VALUES (@Title, @Author, @CatID, @Qty)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Title", book.Title);
                    cmd.Parameters.AddWithValue("@Author", book.Author);
                    cmd.Parameters.AddWithValue("@CatID", book.CategoryID);
                    cmd.Parameters.AddWithValue("@Qty", book.Quantity);

                    await con.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<DataTable> GetAllBooksAsync()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_connectionString))
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

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    await con.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public async Task UpdateBookAsync(Book book)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE Books 
                                 SET Title = @Title, 
                                     Author = @Author, 
                                     CategoryID = @CatID, 
                                     Quantity = @Qty
                                 WHERE BookID = @Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", book.BookID);
                    cmd.Parameters.AddWithValue("@Title", book.Title);
                    cmd.Parameters.AddWithValue("@Author", book.Author);
                    cmd.Parameters.AddWithValue("@CatID", book.CategoryID);
                    cmd.Parameters.AddWithValue("@Qty", book.Quantity);

                    await con.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteBookAsync(int bookId)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Books WHERE BookID = @Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", bookId);
                    await con.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}