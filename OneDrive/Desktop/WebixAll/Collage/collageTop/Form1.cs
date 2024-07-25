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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblSDate_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Collagemanager.SendMachzor(txtMname.Text, txtCname.Text, txtSD.Text, float.Parse(txtPri.Text));
          var rsult= Collagemanager.Getmachzorex(txtMname.Text);
            MessageBox.Show("This Is the Amount the Machzor will Cost the Collage"+"$"+rsult);
        }

        private void btnEnterSch_Click(object sender, EventArgs e)
        {
            Collagemanager.sendSchedule(txtMname.Text,txtDay.Text,txtHour.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
