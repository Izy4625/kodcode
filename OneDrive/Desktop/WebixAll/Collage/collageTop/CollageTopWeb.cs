using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collageTop
{
    public partial class CollageTopWeb : Form
    {
        public CollageTopWeb()
        {
            InitializeComponent();
        }

        private void  button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            student1 student1 = new student1();
            student1.Show();
        }
    }
}
