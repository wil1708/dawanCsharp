using ProjetWinform.DAO;
using ProjetWinform.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.Service
{
   public class UtilisateurService
    {
        UtilisateurDAO dao = new UtilisateurDAO();

        public void AddUser(Utilisateur u, SqlConnection cnx)
        {
            dao.insert(u, cnx);
        }

        public List<Utilisateur> getAllUsers(SqlConnection cnx)
        {
            return dao.getAll(cnx);
        }

        public void deleteUser(string login, SqlConnection cnx)
        {
            dao.delete(login, cnx);
        }

        public Utilisateur findByLogin(string login, SqlConnection cnx)
        {
            return dao.getByLogin(login, cnx);
        }

        public void updateUser(Utilisateur u, SqlConnection cnx)
        {
            dao.update(u, cnx);
        }
    }
}
