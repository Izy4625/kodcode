using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collageTop
{
    internal class DataBase
    {
        static SqlConnection sqlConnection;
        static string connectionString = "server = DESKTOP-56LAE3R\\SQLSERVER; Initial Catalog=Course; user id=sa; password=1234;TrustServerCertificate=Yes";
        public static bool Connect()
        {
            try
            {   //CPNNECTS to th data base
                sqlConnection = new SqlConnection(connectionString);
                //opens it upon
                sqlConnection.Open();
                //makes sure the connection is secure
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static SqlDataReader RunSQLSCollageInsert(string sql,
          string[] parameters = null, object[] values = null)
        {


            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                        cmd.BeginExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    return null;
                }
            }
            return null;


        }
        public static string runSQLSingleresult(string sql, string[] parameters = null, string[] values = null)

        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    return cmd.ExecuteScalar().ToString();
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            return "";


        }
    }
}
