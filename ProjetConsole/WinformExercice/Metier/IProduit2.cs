using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformExercice.Model;

namespace WinformExercice
{
    public interface IProduit2
    {
        void Insert(Produit2 p, SqlConnection cnx);
        List<Produit2> FindByKey(string key, SqlConnection cnx);
        List<Produit2> GetAll(SqlConnection cnx);
        Produit2 GetById(int id, SqlConnection cnx);
        void Update(Produit2 p, SqlConnection cnx);
        void DeleteById(int id, SqlConnection cnx);
    }
}
