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
    public class ProduitDAO : IProduit
    {
        /*
        * Commande de lecture (SELECT) : cmd.executeReader()
        * Commande d'ecriture (Insert, Delete, Update)
        */
        public void deleteById(int id, SqlConnection cnx)
        {
            //SQL
            string sql = "DELETE FROM produit WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        

        public List<Produit> findByKey(string key, SqlConnection cnx)
        {
            List<Produit> produits = new List<Produit>();
            string sql = "SELECT * FROM produit WHERE description LIKE @key";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.Parameters.AddWithValue("@key", "%" + key + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Produit p = new Produit();
                p.Id = reader.GetInt32(0);
                p.Description = reader.GetString(1);
                p.Prix = reader.GetDouble(2);
                p.Quantite = reader.GetInt32(3);
                produits.Add(p);
            }
            reader.Close();
            cnx.Close();

            return produits;
        }

        public List<Produit> getAll(SqlConnection cnx)
        {
            List<Produit> produits = new List<Produit>();
            string sql = "SELECT * FROM produit";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Produit p = new Produit();
                p.Id = reader.GetInt32(0);
                p.Description = reader.GetString(1);
                p.Prix = reader.GetDouble(2);
                p.Quantite = reader.GetInt32(3);
                produits.Add(p);
            }
            reader.Close();
            cnx.Close();

            return produits;
        }

            public Produit getById(int id, SqlConnection cnx)
            {
                Produit produit = new Produit();
                string sql = "SELECT * FROM produit WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    produit.Id = reader.GetInt32(0);
                    produit.Description = reader.GetString(1);
                    produit.Prix = reader.GetDouble(2);
                    produit.Quantite = reader.GetInt32(3);
                    
                }
                reader.Close();
                cnx.Close();

                return produit;

            }
        

        public void insert(Produit p, SqlConnection cnx)
        {
            //Requête SQL (paramétrée): précompilée (chargée en mémoire en attente de params)
            string sql = "INSERT INTO produit (id, description, prix, quantite) VALUES (@id, @description, @prix, @quantite)";
            //Créer un objet SqlCommand
            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.Parameters.AddWithValue("@id", p.Id);
            cmd.Parameters.AddWithValue("@description", p.Description);
            cmd.Parameters.AddWithValue("@prix", p.Prix);
            cmd.Parameters.AddWithValue("@quantite", p.Quantite);

            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void update(Produit p, SqlConnection cnx)
        {
            string sql = "UPDATE produit SET description=@description, prix=@prix, quantite=@quantite WHERE id =@id";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            
            cmd.Parameters.AddWithValue("@description", p.Description);
            cmd.Parameters.AddWithValue("@prix", p.Prix);
            cmd.Parameters.AddWithValue("@quantite", p.Quantite);
            cmd.Parameters.AddWithValue("@id", p.Id);

            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }


}
