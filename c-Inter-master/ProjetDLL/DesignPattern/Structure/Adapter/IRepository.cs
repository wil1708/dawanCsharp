using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Structure.Adapter
{
    public interface IRepository
    {
        string FindXmlContacts(string path);
        List<Contact> FromString(string xml);
    }
}
