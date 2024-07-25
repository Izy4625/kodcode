using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guest
{
    internal class DBConnection
    {

        static SqlConnection sqlConnection;
        static string connectionString = "server = DESKTOP-56LAE3R\\SQLSERVER; Initial Catalog=HostingShabbat; user id=sa; password=1234;TrustServerCertificate=Yes";
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
        public static SqlDataReader RunSQLSallresult(string sql,
            string[] parameters = null, string[] values = null)
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
        public static SqlDataReader RunSQLSHostInsert(string sql,
            string[] parameters = null, string[] values = null)
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
        public static DataTable Runsqltable(string sql, string[] parameters = null, string[] values = null)
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
                    DataTable dataTable = new DataTable();

                    // create data adapter
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    // this will query your database and return the result to your datatable
                    da.Fill(dataTable);


                    return dataTable;
                }
                catch (SqlException ex)
                {
                    return null;
                }
            }
            return null;

        }
    }
    
}