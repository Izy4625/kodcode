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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            List<GuestInvitations> forms = new List<GuestInvitations>();
            List<string> Categories = GuestManager.GetCategories();
            for (int i = 0; i < Categories.Count; i++)
            {
                forms.Add(new GuestInvitations(forms, i, Categories[i], txtIGuest.Text));
            }
            forms.First().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> categories = new List<string>();
            categories = GuestManager.GetGuests();
            for (int i = 0; i < categories.Count; i++)
            {
                lstGuests.Items.Add(categories[i]);
            }

        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lstCategorieGuests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuestManager.SendGuest(txtIGuest.Text);
            MessageBox.Show("succesfully sent");
        }
    }
}
