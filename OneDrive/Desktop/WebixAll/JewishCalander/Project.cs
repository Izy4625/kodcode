using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JewishCalander
{
    internal class Project
    {
        private static string _pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\Calander.xml");
        public static XmlDocument Main()
        {
            if (File.Exists(_pathString))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(_pathString);
                return xmlDoc;
            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlNode Calendar = xmlDoc.CreateElement("Queries");
                xmlDoc.AppendChild(Calendar);
                xmlDoc.Save(_pathString);

            }
            return null;
        }

        public static void Save(XmlDocument xmlDocument)
        {

            xmlDocument.Save(_pathString);
        }
    }
}
