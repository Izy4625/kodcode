using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace xmlpractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _pathsting  = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..") + "\\MenuFood.xml";
            if (Directory.Exists(_pathsting))
            {
                XmlDocument xmldoc = new XmlDocument();
                XmlNode food = xmldoc.CreateElement("food");
                food.InnerText = txtfd.Text;
                xmldoc.Load(_pathsting);
                xmldoc.FirstChild.AppendChild(food);

            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode Menu = xmlDoc.CreateElement("MenuFood");
                xmlDoc.AppendChild(Menu);
                xmlDoc.Save(_pathsting);
            }
        }
    }
}
