using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.SingleResponsability.Good
{
    public class Connexion
    {
        public static SqlConnection getConnexion()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.Open();
            return cnx;
        }
    }
}
