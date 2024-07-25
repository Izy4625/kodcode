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

namespace preTestXml
{
    public partial class Form1 : Form
    {
        
       
           public string _pathsting = Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\MenuFood.xml";
            
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode Menu = xmlDoc.CreateElement("MenuFood");
                xmlDoc.AppendChild(Menu);
                xmlDoc.Save(_pathsting);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNode food = xmldoc.CreateElement("food");
            food.InnerText = txtfd.Text;
            xmldoc.Load(_pathsting);
            xmldoc.FirstChild.AppendChild(food);
            xmldoc.Save(_pathsting);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument xmld = project.Main();
            List<string> menu = new List<string>();
            XmlNodeList FoodList = xmld.SelectNodes("MenuFood");
            foreach (XmlNode FoodNode in FoodList)
            {
                menu.Add(FoodNode.InnerText);
            }
            dgv.Rows.Add(menu.ToArray());
        }
                
    }
}
