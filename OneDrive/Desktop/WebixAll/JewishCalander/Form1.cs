using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JewishCalander
{
    public partial class Form1 : Form

    {
        private List<string> results = new List<string>();
        private CalendarManager calendarManager;
        public Form1()
        {
            InitializeComponent();
            XmlDocument calendarDocument = Project.Main();
            calendarManager = new CalendarManager(calendarDocument);

        }

        private void button1_Click(object sender, EventArgs e)
            
        {
            string res = CalendarManager.GetResult(results);
            List<string> Query = new List<string>()
            {
                cbD.Text,
                cbDM.Text,
                cbM.Text,
                cbY.Text,
                res



            };
           string result = CalendarManager.AddQuery(Query);
            MessageBox.Show(result);
        }

        private void cbD_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Get the selected item
            string selectedItem = cbD.Text;
            string result = "";
            // Use a switch statement to set the result string
            switch (selectedItem)
            {
                case "Monday":
                    result = " Second day of the week";
                    break;
                case "Tuesday":
                    result = "Third day of the week";
                    break;
                case "Wednesday":
                    result = "Fourth day of the week";
                    break;
                case "Thursday":
                    result = "Fifth day of the week";
                    break;
                case "Friday":
                    result = "six day of the week";
                    break;

                case "Sunday":
                    result = "First day of the week";
                    break;
                default:
                    result = "Unknown day";
                    break;
            }
            results.Add(result);

        }

        private void cbDM_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Get the selected item as a string
            string selectedDay = cbDM.Text;
            string result = "";

            // Use a switch statement to set the result string
            switch (selectedDay)
            {
                case "1":
                    result = "First day of the month";
                    break;
                case "2":
                    result = "Second day of the month";
                    break;
                case "3":
                    result = "Third day of the month";
                    break;
                case "4":
                    result = "Fourth day of the month";
                    break;
                case "5":
                    result = "Fifth day of the month";
                    break;
                case "6":
                    result = "Sixth day of the month";
                    break;
                case "7":
                    result = "Seventh day of the month";
                    break;
                case "8":
                    result = "Eighth day of the month";
                    break;
                case "9":
                    result = "Ninth day of the month";
                    break;
                case "10":
                    result = "Tenth day of the month";
                    break;
                case "11":
                    result = "Eleventh day of the month";
                    break;
                case "12":
                    result = "Twelfth day of the month";
                    break;
                case "13":
                    result = "Thirteenth day of the month";
                    break;
                case "14":
                    result = "Fourteenth day of the month";
                    break;
                case "15":
                    result = "Fifteenth day of the month";
                    break;
                case "16":
                    result = "Sixteenth day of the month";
                    break;
                case "17":
                    result = "Seventeenth day of the month";
                    break;
                case "18":
                    result = "Eighteenth day of the month";
                    break;
                case "19":
                    result = "Nineteenth day of the month";
                    break;
                case "20":
                    result = "Twentieth day of the month";
                    break;
                case "21":
                    result = "Twenty-first day of the month";
                    break;
                case "22":
                    result = "Twenty-second day of the month";
                    break;
                case "23":
                    result = "Twenty-third day of the month";
                    break;
                case "24":
                    result = "Twenty-fourth day of the month";
                    break;
                case "25":
                    result = "Twenty-fifth day of the month";
                    break;
                case "26":
                    result = "Twenty-sixth day of the month";
                    break;
                case "27":
                    result = "Twenty-seventh day of the month";
                    break;
                case "28":
                    result = "Twenty-eighth day of the month";
                    break;
                case "29":
                    result = "Twenty-ninth day of the month";
                    break;
                default:
                    result = "Invalid day";
                    break;
            }
            results.Add(result);

        }

        private void cbM_SelectedIndexChanged(object sender, EventArgs e)
        {
            results.Add(cbM.Text);
        }

        private void cbY_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear = int.Parse(cbY.SelectedItem.ToString());
            string result = "";
            // Use a switch statement to set the result string
            switch (selectedYear)
            {
                case 5785:
                    result = "And five thousand seven hundred eighty-five years from the Creation of the world";
                    break;
                case 5786:
                    result = "And five thousand seven hundred eighty-six years from the Creation of the world";
                    break;
                case 5787:
                    result = "And five thousand seven hundred eighty-seven years from the Creation of the world";
                    break;
                case 5788:
                    result = "And five thousand seven hundred eighty-eight years from the Creation of the world";
                    break;
                case 5789:
                    result = "And five thousand seven hundred eighty-nine years from the Creation of the world";
                    break;
                case 5790:
                    result = "And five thousand seven hundred ninety years from the Creation of the world";
                    break;
                case 5791:
                    result = "And five thousand seven hundred ninety-one years from the Creation of the world";
                    break;
                case 5792:
                    result = "And five thousand seven hundred ninety-two years from the Creation of the world";
                    break;
                case 5793:
                    result = "And five thousand seven hundred ninety-three years from the Creation of the world";
                    break;
                case 5794:
                    result = "And five thousand seven hundred ninety-four years from the Creation of the world";
                    break;
                default:
                    result = "Year not covered in the switch case.";
                    break;
            }
            results.Add(result);
        }
        public void  SendResult()
        {
           string res = CalendarManager.GetResult( results);
             MessageBox.Show(res);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalendarManager.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
            
        }
    }
}
