using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform
{
    public class Connexion
    {
        public static SqlConnection getConnexion()
        {
            //Chemin d'accès à la base de donnée : ConnectionString
            string ch = ConfigurationManager.ConnectionStrings["chConnexion"].ConnectionString;
            //Etablir la connexion
            SqlConnection cnx = new SqlConnection(ch);

            cnx.Open();

            return cnx;
        }


    }
}
