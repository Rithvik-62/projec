using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QRDocVault
{
    public static class DbHelper
    {
        // FIXED: Removed spaces from 'TrustServerCertificate' to resolve image_3dffa6.png
        // If 'Server=.' fails, check SSMS for your server name (e.g. Server=.\\SQLEXPRESS)
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QRDocVaultDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        /// <summary>
        /// Executes a SELECT query and returns a DataTable.
        /// </summary>
        public static DataTable ExecuteQuery(string sql, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // 5-second timeout to prevent the app from freezing if the DB is offline
                        cmd.CommandTimeout = 5;

                        if (parameters != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log to console to prevent "Ghost" windows blocking startup
                Console.WriteLine("Database Retrieval Error: " + ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// Executes INSERT, UPDATE, or DELETE commands.
        /// </summary>
        public static void ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        if (parameters != null)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddRange(parameters);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // This catches the 'Truncation' error shown in image_3d0b86.png
                // REQUIREMENT: Run the SQL command below in SSMS to fix the database schema
                MessageBox.Show("Database Action Error: " + ex.Message +
                    "\n\n🚨 CRITICAL FIX: Run the following SQL in Management Studio:\n" +
                    "ALTER TABLE AccessLog ALTER COLUMN AccessMode VARCHAR(250);",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}