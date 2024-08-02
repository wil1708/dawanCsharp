using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Generic
{
    public class Tools
    {
        public static string ToJson<T>(T p)
        {
            string result = null;
            DataContractJsonSerializer js = new DataContractJsonSerializer(p.GetType());
            MemoryStream flux = new MemoryStream();
            js.WriteObject(flux, p);
            flux.Close();
            result = Encoding.UTF8.GetString(flux.ToArray());
            return result;
        }

        public static void ToCSV<T>(List<T> lst, string path)
        {
            
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (T obj in lst)
                {
                    //Récupérer toutes les proriétés de l'objet en question
                    PropertyInfo[] tab = obj.GetType().GetProperties();

                    StringBuilder sb = new StringBuilder();
                    foreach (PropertyInfo prop in tab)
                    {
                       sb.Append(prop.GetValue(obj).ToString()).Append(";");
                    }
                    sw.WriteLine(sb.ToString().Substring(0, sb.Length - 1));
                }
            }
        }

        public static List<T> FromCSV<T>(string path)
        {
            List<T> lst = new List<T>();

            using (StreamReader sr = new StreamReader(path))
            {
                Type objType = typeof(T);
                PropertyInfo[] props = objType.GetProperties();

                //Lire le contenu du fichier ligne par ligne - transformer chaque ligne en un objet de type T

                while (!sr.EndOfStream)
                {
                    T obj = (T)Activator.CreateInstance(objType);
                    string ligne = sr.ReadLine();
                    if (ligne != null)
                    {
                        string[] tab = ligne.Split(';');
                        for (int i = 0; i < props.Length; i++)
                        {
                            props[i].SetValue(obj, Convert.ChangeType(tab[i], props[i].PropertyType));
                        }
                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }
    }
}
