using ProjetWinform.Metier;
using ProjetWinform.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.DAO
{
    public class ProduDAO2 : IProduit2
    {
        public void deleteById(int id)
        {
            SqlConnection cnx = ConnexionSQL.getConnexion();

            
        }

        public List<Produit> findByKey(string key)
        {
            throw new NotImplementedException();
        }

        public List<Produit> getAll()
        {
            throw new NotImplementedException();
        }

        public Produit getById(int id)
        {
            throw new NotImplementedException();
        }

        public void insert(Produit p)
        {
            throw new NotImplementedException();
        }

        public void update(Produit p)
        {
            throw new NotImplementedException();
        }
    }
}
