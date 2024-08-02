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
    public class MySqlProd : IProduit
    {
        public void deleteById(int id, SqlConnection cnx)
        {
            throw new NotImplementedException();
        }

        public List<Produit> findByKey(string key, SqlConnection cnx)
        {
            throw new NotImplementedException();
        }

        public List<Produit> getAll(SqlConnection cnx)
        {
            throw new NotImplementedException();
        }

        public Produit getById(int id, SqlConnection cnx)
        {
            throw new NotImplementedException();
        }

        public void insert(Produit p, SqlConnection cnx)
        {
            throw new NotImplementedException();
        }

        public void update(Produit p, SqlConnection cnx)
        {
            throw new NotImplementedException();
        }
    }
}
