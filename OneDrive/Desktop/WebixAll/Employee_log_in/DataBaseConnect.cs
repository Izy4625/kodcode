using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_log_in
{
    internal class DataBaseConnect
    {

        static SqlConnection sqlConnection;
        static string connectionString = "server = DESKTOP-56LAE3R\\SQLSERVER; Initial Catalog=timeclock; user id=sa; password=1234;TrustServerCertificate=Yes";
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
        public static SqlDataReader runSQLSallresult(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {   //class to
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

                    return cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    return null;
                }
            }
            return null;


        }
    
          
        
        public static string runSQLSingleresult(string sql, string[] parameters = null, string[] values=null)

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
    

        
        public static string Runsqltable(string sql)
        {
            if (Connect())
            {
                try
                {
                    DataTable dataTable = new DataTable();

                    SqlCommand cmd = new SqlCommand(sql);


                    // create data adapter
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    // this will query your database and return the result to your datatable
                    da.Fill(dataTable);

                    da.Dispose();
                    return dataTable.ToString();
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
