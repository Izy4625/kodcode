using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_log_in
{
    public partial class Formlearning : Form
    {
        public Formlearning()
        {
            InitializeComponent();
        }

        private void Formlearning_Load(object sender, EventArgs e)
        {
            string sql = "select count(*) from Attendances";
            SqlDataReader reader = DataBaseConnect.runSQLSallresult(sql);

            while(reader.Read())
            {
               int code = reader.GetInt32(0);
               string str = reader.GetString(1);
               reader.GetString(2);
            MessageBox.Show();
            }

        }
    }
}
