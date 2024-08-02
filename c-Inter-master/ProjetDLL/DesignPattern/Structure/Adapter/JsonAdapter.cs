using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Structure.Adapter
{
    public class JsonAdapter : IJsonAdapter
    {
        private IRepository xmlRepo;

        public JsonAdapter(IRepository xmlRepo)
        {
            this.xmlRepo = xmlRepo;
        }

        public string FindJsonContacts(string path)
        {
            string xml = xmlRepo.FindXmlContacts(path);
            List<Contact> lst = xmlRepo.FromString(xml);

            //transformation du contenu xml en json
            string result = null;
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(lst.GetType());

            using (MemoryStream stream = new MemoryStream())
            {
                serializer.WriteObject(stream, lst);
                result = Encoding.UTF8.GetString(stream.ToArray());
            }
            return result;
        }
    }
}
