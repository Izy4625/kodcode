using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JewishCalander
{
    internal class CalendarManager
    {
        private static XmlDocument _document;
        public CalendarManager(XmlDocument doc)
        {
            _document = doc;
        }

        public  static string GetResult(List<string> results)
        {           

            string result = results.Aggregate((current, next) => current + " " + next);
            return result;
        }
        private static XmlNode GetRoot()
        {
            return _document.GetElementsByTagName("Queries")[0];
        }
        public static string AddQuery(List<string> Query)
        {
            XmlElement QueryElemnt = _document.CreateElement("Query");
            List<string> tagsName = new List<string>() { "Day", "DayMonth", "Month", "Year", "Result" };
            for (int i = 0; i < tagsName.Count; i++)
            {
                XmlElement child = _document.CreateElement(tagsName[i]);
                child.InnerText = Query[i];
                QueryElemnt.AppendChild(child);
            }
            
            
            GetRoot().AppendChild(QueryElemnt);
            return Query[4];
            
            
                      
        }
        public static string GetResultNode()
        {
            
            XmlNode res = _document.SelectSingleNode(@"Queries\Query\[Results] = ");
            return res.InnerText;

        }
        public static  void Save()
        {
            Project.Save(_document);
        }

    }
}
