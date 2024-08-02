using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformExercice.Model;

namespace WinformExercice.DAO
{
    public class Produit2DAO
    {
        public void DeleteById(int id, SqlConnection cnx)
        {
            string sql = "DELETE FROM produit WHere id=@id";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public List<Produit2> FindByKey(string key, SqlConnection cnx)
        {
            List<Produit2> produits = new List<Produit2>();
            string sql = "SELECT * FROM produit WHERE description LIKE @key";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.Parameters.AddWithValue("@key", "%" + key + "%");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Produit2 p = new Produit2();
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

        public Produit2 GetById(int id, SqlConnection cnx)
        {
            Produit2 produit = new Produit2();
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

        public List<Produit2> GetAll(SqlConnection cnx)
        {
            List<Produit2> produits = new List<Produit2>();
            string sql = "SELECT * FROM produit";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Produit2 p = new Produit2();
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

        public void Update(Produit2 p, SqlConnection cnx)
        {
            string sql = "UPDATE produit SET description=@description, prix=@prix, quantite=@quantite WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, cnx);

            cmd.Parameters.AddWithValue("@description", p.Description);
            cmd.Parameters.AddWithValue("@prix", p.Prix);
            cmd.Parameters.AddWithValue("@quantite", p.Quantite);
            cmd.Parameters.AddWithValue("@id", p.Id);

            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void Insert(Produit2 p, SqlConnection cnx)
        {
            string sql = "INSERT INTO produit(id, description, prix, quantite) VALUES(@id, @description, @prix, @quantite)";

            SqlCommand cmd = new SqlCommand(sql, cnx);

            cmd.Parameters.AddWithValue("@id", p.Id);
            cmd.Parameters.AddWithValue("@description", p.Description);
            cmd.Parameters.AddWithValue("@prix", p.Prix);
            cmd.Parameters.AddWithValue("@quantite", p.Quantite);

            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }
}
