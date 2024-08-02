using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformExercice
{
    public class Connexion
    {
        public static SqlConnection GetConnexion()
        {
            string ch = ConfigurationManager.ConnectionStrings["chConnexion"].ConnectionString;

            SqlConnection cnx = new SqlConnection(ch);

            cnx.Open();

            return cnx;
        }
    }
}
