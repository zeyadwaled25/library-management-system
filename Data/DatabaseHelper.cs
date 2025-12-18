using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LibraryManagementSystem.Data
{
    internal class DatabaseHelper
    {

        private static readonly string connectionString =
            ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static DataTable ExecuteSelect(string query, SqlParameter[] parameters = null)
        {
            using SqlConnection con = GetConnection();
            using SqlCommand cmd = new SqlCommand(query, con);

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            using SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using SqlConnection con = GetConnection();
            using SqlCommand cmd = new SqlCommand(query, con);

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            con.Open();
            return cmd.ExecuteNonQuery();
        }

        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using SqlConnection con = GetConnection();
            using SqlCommand cmd = new SqlCommand(query, con);

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            con.Open();
            return cmd.ExecuteScalar();
        }
    }
}