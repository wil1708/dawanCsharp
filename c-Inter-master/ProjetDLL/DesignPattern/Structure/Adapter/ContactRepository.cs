using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjetDLL.DesignPattern.Structure.Adapter
{
    public class ContactRepository : IRepository
    {
        public string FindXmlContacts(string path)
        {
            string result = null;
            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }

        public List<Contact> FromString(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            List<Contact> lst = new List<Contact>();
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/Contacts/Contact");

            foreach (XmlNode node in nodes)
            {
                Contact c = new Contact();
                c.Id = Convert.ToInt32(node.Attributes["id"].Value);
                c.Name = node.ChildNodes[0].InnerText;
                lst.Add(c);
            }
            return lst;
        }
    }
}
