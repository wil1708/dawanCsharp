using MySql.Data.MySqlClient;
using ProjetWinform.Metier;
using ProjetWinform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.DAO
{
    public class MySqlProdDAO : IProduit2
    {
        public void deleteById(int id)
        {
            //SQL
            MySqlConnection cnx = null;
            string sql = "DELETE FROM produit WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, cnx);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cnx.Close();

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
