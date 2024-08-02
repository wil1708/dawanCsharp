using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTraining.Entites;

namespace WPFTraining.Services
{
    public class FichierService
    {
        public static void ExportCSV(string cheminFichier, char separateur, List<Produit> produits)
        {
            using (StreamWriter sw = new StreamWriter(cheminFichier, false, Encoding.UTF8))
                foreach (Produit p in produits)
                {
                    sw.Write(p.Id + separateur +p.Description + separateur + p.Prix);
                }
        }

        public static List<Produit> ImportCSV(string cheminFichier, char separateur, out List<string> lignesIgnorees)
        {
            List<Produit> resultat = new List<Produit>();
            lignesIgnorees = new List<string>();
            using (StreamReader sr = new StreamReader(cheminFichier, Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if(line != null && line.Trim().Length > 0)
                    {
                        string[] tab = line.Split(separateur);
                        try
                        {
                            resultat.Add(new Produit(
                                Convert.ToInt32(tab[0]),
                                tab[1],
                                Convert.ToDouble(tab[2])
                                ));
                        }
                        catch (Exception ex)
                        {
                            lignesIgnorees.Add(line);                           
                        }
                    }
                }
            }
            return resultat;
        }
    }
}
