 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Xml_le
{
    internal class xmlNodes
    {


        
            public XmlDocument XmlDocument { get; set; }
            public xmlNodes(XmlDocument xmlDocument)
            {
                XmlDocument = xmlDocument;
            }

            public void GetAllEmployees(XmlNodeList xmlNodeList = null)
            {
                if (xmlNodeList == null)
                {
                    xmlNodeList = XmlDocument.SelectNodes("/Employees/Employee");
                }
                foreach (XmlNode children in xmlNodeList)
                {
                    if (children.Attributes != null)
                    {
                        // Check all attributes
                        foreach (XmlAttribute attribute in children.Attributes)
                        {
                            Console.WriteLine(attribute.Name + ": " + attribute.Value);
                        }
                    }
                    if (children.ChildNodes != null)
                    {
                        GetAllEmployees(children.ChildNodes);
                    }
                }
            }
        }
    }




    // 3. Search for all employees   //xmlDoc.SelectNodes();



