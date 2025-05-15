using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Appointment_System
{
    public class DatabaseManager
    {

        String connectionString;
        public DatabaseManager()
        {
            connectionString = @"Server=(LocalDB)\MSSQLLocalDB;Database=AA_Assignment_Hospital;Trusted_Connection=True;";
        }


        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public DataTable ExecuteSelect(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                conn.Open();
                adapter.Fill(dt);
            }
            return dt;
        }


        public int ExecuteNonQuery(string query, List<SqlParameter> parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
