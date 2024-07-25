using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace preTestXml
{
    internal class project
    {
        private static string _pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\MenuFood.xml");
        public static XmlDocument Main()
        {
            if (File.Exists(_pathString))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(_pathString);
                return xmlDoc;
            }
            return null;
        }
    }
}
