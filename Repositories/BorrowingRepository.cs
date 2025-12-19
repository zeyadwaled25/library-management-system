using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using LibraryManagementSystem.Data;

namespace LibraryManagementSystem.Repositories
{
    public class BorrowingRepository
    {
        public async Task<DataTable> GetAvailableBooksAsync()
        {
            return await Task.Run(() =>
            {
                string query = "SELECT BookID, Title FROM Books WHERE Quantity > 0";
                return DatabaseHelper.ExecuteSelect(query);
            });
        }

        public async Task<DataTable> GetAllMembersAsync()
        {
            return await Task.Run(() =>
            {
                string query = "SELECT MemberID, FullName FROM Members WHERE IsActive = 1";
                return DatabaseHelper.ExecuteSelect(query);
            });
        }

        public async Task<DataTable> GetCurrentBorrowingsAsync()
        {
            return await Task.Run(() =>
            {
                string query = @"
                    SELECT 
                        b.BorrowID, 
                        bk.Title AS BookTitle, 
                        m.FullName AS MemberName, 
                        b.BorrowDate,
                        b.ReturnDate AS ExpectedReturn 
                    FROM Borrowings b 
                    JOIN Books bk ON b.BookID = bk.BookID 
                    JOIN Members m ON b.MemberID = m.MemberID 
                    WHERE b.Status = 'Borrowed'";

                return DatabaseHelper.ExecuteSelect(query);
            });
        }

        public async Task IssueBookAsync(int bookId, int memberId, DateTime returnDate)
        {
            await Task.Run(() =>
            {
                string query = "AddBorrowing";

                SqlParameter[] p = {
                    new("@BookID", bookId),
                    new("@MemberID", memberId),
                    new("@ExpectedReturnDate", returnDate)
                };

                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(p);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            });
        }

        public async Task ReturnBookAsync(int borrowId)
        {
            await Task.Run(() =>
            {
                string query = "ReturnBook";
                SqlParameter[] p = { new("@BorrowID", borrowId) };

                using (var con = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(p);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            });
        }
    }
}