using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xml_le
{
    public class Xml_First_Project
    {
        public static XmlDocument Main()
        {

            string pathString = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..") + "\\Employees.xml";
            Console.WriteLine("Project Directory: " + pathString);
            // 1.2 Check if file exists

            if (File.Exists(pathString))
            {
                // 1.3 Create a new instance of type XmlDocument
                XmlDocument xmlDoc = new XmlDocument();
                // 1.4 Try and load the XML content into the XmlDocument object
                xmlDoc.Load(pathString);
                // 2. Search for Employee
                return xmlDoc;

            }

            else
            {
                Console.WriteLine("File not found");
                XmlDocument xmlDoc = new XmlDocument();
                return xmlDoc;


            }



        }


    }
   
}

