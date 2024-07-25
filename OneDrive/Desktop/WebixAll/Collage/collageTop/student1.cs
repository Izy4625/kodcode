using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collageTop
{
    public partial class student1 : Form
    {
        public student1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Collagemanager.sendStudent(txtSn.Text, txtMn.Text);
            Collagemanager.Updatepayment(txtSn.Text, txtMn.Text);
            MessageBox.Show("You Must Pay To Finish the signing up process");
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
             var result  = Collagemanager.GetBalance(txtSn.Text);
            lblAmount.Text ="This is Your Balance:"+ "$" +result ;
        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Collagemanager.PayBalnce(txtSn.Text, float.Parse(txtPay.Text));
        }

        private void student1_Load(object sender, EventArgs e)
        {

        }
    }
}
