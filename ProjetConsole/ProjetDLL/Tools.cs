using ProjetDLL.Encapsulation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetDLL
{
    //Contient les parties sur les fichiers, la sérialisation (xml, json, binaire)
     public class Tools
    {
        //Methode d'écriture dans un fichier
        public static void EcritureFichier(string path, string contenu)
        {
            if(File.Exists(path))
            {
                StreamWriter sw = new StreamWriter (path, true);
                sw.Write(contenu);
                sw.Close();
            }
            else
            {
                throw new Exception("Chemin inexistant");
            }
        }

        //Méthode de lecture du contenu d'un fichier
        public static string LectureFichier(string path)
        {
            string contenu = "";
            if (File.Exists(path))
            {
                //Using with ressource - se charge de libérer les ressources à la fin d'exécution des opérations
                //Donc plus la peine de mettre close, pour libérer la ressource
                using(StreamReader sr = new StreamReader(path))
                {
                    contenu = sr.ReadToEnd();
                    return contenu;
                }
            }
            else
            {
                return "Fichier Introuvable";
            }
        }

        //Methode sauvegarde
        public static void ExportBin(string path, List<CompteBancaire> listCB)
        {
            //Créer le flux et charger le fichier dessus en mode écriture
            FileStream fs = new FileStream(path, FileMode.Create);

            //Utiliser la classe de sérialisation binaire
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listCB);
            fs.Close();

        }

        //Methode de restauration BIN (Lecture du fichier Binaire)
        public static List<CompteBancaire> ImportBin(string path)
        {
            List<CompteBancaire> listCBbin = new List<CompteBancaire>();

            if(File.Exists(path))
            {
                //Charger le fichier dans un flux en mode lecture
                FileStream fs = new FileStream(path, FileMode.Open);

                //utilisation de la sérialisation binaire
                BinaryFormatter bf = new BinaryFormatter();
                listCBbin = (List<CompteBancaire>)bf.Deserialize(fs);
            }
            else
            {
                throw new Exception("Fichier introuvable");
            }
            return listCBbin;
        }

        //Methode de sauvegarde XML
        public static void ExportXML(string path, List<CompteBancaire> listCB)
        {
            //Flux en mode écriture
            FileStream fs = new FileStream(path, FileMode.Create);

            //Utilisation de la classe sérialisation XML
            XmlSerializer ser = new XmlSerializer(listCB.GetType());
            ser.Serialize(fs, listCB);
            fs.Close();
        }

        //Extraire (lecture le fichier XML
        public static List<CompteBancaire> ImportXML(string path)
        {
            List<CompteBancaire> listXML = new List<CompteBancaire>();

            if (File.Exists(path))
            {
                //Flux en mode lecture
                FileStream fs = new FileStream(path, FileMode.Open);
                XmlSerializer ser = new XmlSerializer(listXML.GetType());
                listXML = (List<CompteBancaire>)ser.Deserialize(fs);
                fs.Close();
            }
            else
            {
                throw new Exception("Fichier XML introuvable");
            }

            return listXML;
        }

        //Methode de sauvegarde JSON
        public static void ExportJSON(string path, List<CompteBancaire> listCB)
        {
            //Flux en mode écriture
            FileStream fs = new FileStream(path, FileMode.Create);

            //Utilisation de la classe sérialisation JSON
            DataContractJsonSerializer ser = new DataContractJsonSerializer(listCB.GetType());
            ser.WriteObject(fs, listCB);
            fs.Close();
        }

        //Methode de restauration (lecture) JSON
        public static List<CompteBancaire> ImportJSON(string path)
        {
            List<CompteBancaire> listCBJson = new List<CompteBancaire>();
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                DataContractJsonSerializer ser = new DataContractJsonSerializer(listCBJson.GetType());
                listCBJson = (List<CompteBancaire>)ser.ReadObject(fs);
                fs.Close();
            }
            else
            {
                throw new Exception("Fichier JSON introuvable");
            }

            return listCBJson;
        }

        //Methode de sauvegarde CSV (Ecriture)
        public static void ExportCSV(string path, List<CompteBancaire> listCB)
        {
            StreamWriter sw = new StreamWriter(path);
            string separator = ";";
            foreach(CompteBancaire compteBancaire in listCB)
            {
                sw.WriteLine(compteBancaire.Numero + separator + compteBancaire.Solde);
            }
            sw.Close();
        }

        //Methode de restauration (lecture) CSV
        public static List<CompteBancaire> ImportCSV(string path)
        {
            List<CompteBancaire> listCB = new List<CompteBancaire>();
            
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                //Lire une ligne et la découper
                while (!sr.EndOfStream)
                {
                    CompteBancaire cb = new CompteBancaire();
                    string ligne = sr.ReadLine();
                    ligne = ligne.Trim();
                    string[] values = ligne.Split(';');
                    cb.Numero = values[0];
                    cb.Solde = Convert.ToDouble(values[1]);
                    listCB.Add(cb);
                }
                sr.Close();
                return listCB;
            } else
            {
                throw new Exception("Fichier CSV introuvable");
            }
            
        }
    }
}
