using ProjetWinform.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.Metier
{
    public interface IUtilisateur
    {
        void insert(Utilisateur u, SqlConnection cnx);
        List<Utilisateur> getAll(SqlConnection cnx);
        void delete(string login, SqlConnection cnx);
        Utilisateur getByLogin(string login, SqlConnection cnx);
        void update(Utilisateur u, SqlConnection cnx);
    }
}

