using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;

namespace _2_DemoController.Tools
{
    public class MyJsonTool
    {
        public static string ToJson<T>(T obj)
        {
            string resultat = null;
            DataContractJsonSerializer serialize = new DataContractJsonSerializer(typeof(T));
            using(MemoryStream stream = new MemoryStream())
            {
                serialize.WriteObject(stream, obj);
                resultat = Encoding.UTF8.GetString(stream.ToArray());
            }
            return resultat;
        }
    }
}