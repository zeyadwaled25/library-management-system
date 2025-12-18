using System.Data;
using Microsoft.Data.SqlClient;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Repositories
{
    public class MemberRepository
    {
        public DataTable GetAll()
        {
            string query = "SELECT MemberID, FullName, Phone, Email FROM Members";
            return DatabaseHelper.ExecuteSelect(query);
        }

        public void Add(Member m)
        {
            string query = @"
                INSERT INTO Members (FullName, Phone, Email)
                VALUES (@Name, @Phone, @Email)";

            SqlParameter[] p =
            {
                new("@Name", m.FullName),
                new("@Phone", m.Phone),
                new("@Email", m.Email)
            };

            DatabaseHelper.ExecuteNonQuery(query, p);
        }

        public void Update(Member m)
        {
            string query = @"
                UPDATE Members
                SET FullName=@Name, Phone=@Phone, Email=@Email
                WHERE MemberID=@Id";

            SqlParameter[] p =
            {
                new("@Name", m.FullName),
                new("@Phone", m.Phone),
                new("@Email", m.Email),
                new("@Id", m.MemberID)
            };

            DatabaseHelper.ExecuteNonQuery(query, p);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM Members WHERE MemberID=@Id";
            SqlParameter[] p = { new("@Id", id) };

            DatabaseHelper.ExecuteNonQuery(query, p);
        }
    }
}
