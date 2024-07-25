using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guest
{
    public partial class GuestInvitations : Form
    {
        //opens up a form LIST that will have many forms in the list the list has the class Ordersummary type form in with many object wich are forms 
        //
        public List<GuestInvitations> Forms2;
        public int Position;
        public string Nameguest;
        //each form 
        public GuestInvitations(List<GuestInvitations> forms2, int position, string categoryname,string name)

        {
            InitializeComponent();

            Forms2 = forms2;
            Position = position;
            lblTitle.Text = categoryname;
            Nameguest = name;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (Position < Forms2.Count)
            {
                Forms2[Position + 1].Visible = true;

            }
            else
            {

                Forms2[Forms2.Count - 1].Visible = true;
            }
        }

        private void GuestInvitations_Load(object sender, EventArgs e)
        {
            dgvOtherGuests.DataSource = GuestManager.SqlForwardTableResult(lblTitle.Text, Nameguest);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
