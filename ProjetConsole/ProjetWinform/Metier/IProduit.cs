using ProjetWinform.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.Metier
{
    public interface IProduit
    {
        void insert(Produit p, SqlConnection cnx);
        List<Produit> findByKey(string key, SqlConnection cnx);
        List<Produit> getAll(SqlConnection cnx);
        Produit getById(int id, SqlConnection cnx);
        void update(Produit p, SqlConnection cnx);
        void deleteById(int id, SqlConnection cnx);
    }
}
