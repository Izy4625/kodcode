using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_log_in
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword();
            frm.Show();
            this.Hide();

        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return;
            string result = EmployeeManager.Login(textBox1.Text, textBox2.Text);
            MessageBox.Show(result);

            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timeclock_Click(object sender, EventArgs e)
        {

        }

        private void Timeclock_KeyPress(object sender, KeyPressEventArgs e)
        {
            string hours = EmployeeManager.PullData();
            MessageBox.Show(hours);
        }
    }
}
