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
    public class UserDAO : IUser
    {
        public void DeleteByLogin(string login)
        {
            //Etablir une connexion à la BD : utiliser la classe SqlConnection
            SqlConnection cnx = ConnexionSQL.GetConnexion();

            //requête SQL paramétrée : une req pré-compilée - chargée en mémoire en attente d'un paramètre
            string sql = "DELETE FROM [user] WHERE login=@login";

            //utiliser la classe SqlCommand
            SqlCommand cmd = new SqlCommand(sql, cnx);

            //Définition des params
            cmd.Parameters.AddWithValue("@login", login);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public User FindByLogin(string login)
        {
            User u = null;
            SqlConnection cnx = ConnexionSQL.GetConnexion();
            string sql = "SELECT * FROM [user] WHERE login=@login";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.Parameters.AddWithValue("@login", login);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                u = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), (Profile)reader.GetByte(3));
            }
            reader.Close();
            cnx.Close();
            return u;
        }

        public List<User> GetAll()
        {
            List<User> lst = new List<User>();
            SqlConnection cnx = ConnexionSQL.GetConnexion();
            string sql = "SELECT * FROM [user]";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               User u = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), (Profile)reader.GetByte(3));
                lst.Add(u);
            }
            reader.Close();
            cnx.Close();
            return lst;
        }

        public void Insert(User u)
        {
            SqlConnection cnx = ConnexionSQL.GetConnexion();
            string sql = "INSERT INTO [user](login, password, photo, profile) VALUES (@login,@password,@photo,@profile)";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            cmd.Parameters.AddWithValue("@login", u.Login);
            cmd.Parameters.AddWithValue("@password", u.Password);
            cmd.Parameters.AddWithValue("@photo", u.Photo);
            cmd.Parameters.AddWithValue("@profile", u.Profile);
            cmd.ExecuteNonQuery();
            cnx.Close();

        }

        public void Update(User u)
        {
            SqlConnection cnx = ConnexionSQL.GetConnexion();
            string sql = "UPDATE [user] SET password=@password, photo=@photo, profile=@profile WHERE login=@login";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            
            cmd.Parameters.AddWithValue("@password", u.Password);
            cmd.Parameters.AddWithValue("@photo", u.Photo);
            cmd.Parameters.AddWithValue("@profile", u.Profile);
            cmd.Parameters.AddWithValue("@login", u.Login);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }
}
