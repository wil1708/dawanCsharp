using ProjetWinform.Metier;
using ProjetWinform.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.DAO
{
    public class UtilisateurDAO : IUtilisateur
    {
        private static string hashPassword(string pwd)
        {
            // Create a SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(pwd));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public void delete(string login, SqlConnection cnx)
        {
            string sql = "DELETE FROM utilisateur WHERE login=@login";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public List<Utilisateur> getAll(SqlConnection cnx)
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            string sql = "SELECT * FROM utilisateur";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Utilisateur u = new Utilisateur();
                u.Login = reader.GetString(0);
                u.Password = reader.GetString(1);
                u.Admin = reader.GetBoolean(2);
                
                utilisateurs.Add(u);
            }
            reader.Close();
            cnx.Close();

            return utilisateurs;
        }

        public Utilisateur getByLogin(string login, SqlConnection cnx)
        {
            Utilisateur u = new Utilisateur();
            string sql = "SELECT * FROM utilisateur WHERE login=@login";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.Parameters.AddWithValue("@login", login);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                u.Login = reader.GetString(0);
                u.Password = reader.GetString(1);
                u.Admin = Convert.ToBoolean(reader.GetValue(2));

            }
            reader.Close();
            cnx.Close();

            return u;
        }

        public void insert(Utilisateur u, SqlConnection cnx)
        {
            string sql = "INSERT INTO utilisateur (login, password, admin) VALUES (@login, @password, @admin)";
            //Créer un objet SqlCommand
            SqlCommand cmd = new SqlCommand(sql, cnx);
            string hashpassword = hashPassword(u.Password);
            cmd.Parameters.AddWithValue("@login", u.Login);
            cmd.Parameters.AddWithValue("@password", hashpassword);
            cmd.Parameters.AddWithValue("@admin", u.Admin);
            

            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void update(Utilisateur u, SqlConnection cnx)
        {
            string sql = "UPDATE utilisateur SET password=@password, admin=@admin WHERE login =@login";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            string hashpassword = hashPassword(u.Password);
            
            cmd.Parameters.AddWithValue("@password", hashpassword);
            cmd.Parameters.AddWithValue("@admin", u.Admin);
            cmd.Parameters.AddWithValue("@login", u.Login);

            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }
}
