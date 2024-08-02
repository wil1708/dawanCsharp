using ProjetWinform.Metier;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.DAO
{
    class ContactDAO : IContact
    {
        public void delete(Contact c)
        {
            SqlConnection cnx = ConnexionSQL.getConnexion();

        }

        public List<Contact> getAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Contact c)
        {
            throw new NotImplementedException();
        }
    }
}
