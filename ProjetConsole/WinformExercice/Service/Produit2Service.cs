using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformExercice.DAO;
using WinformExercice.Model;

namespace WinformExercice.Service
{
    public class Produit2Service
    {
        Produit2DAO dao = new Produit2DAO();

        public void DeleteProduit2(int id, SqlConnection cnx)
        {
            dao.DeleteById(id, cnx);
        }

        public List<Produit2> FindByKey(string key, SqlConnection cnx)
        {
            return dao.FindByKey(key, cnx);
        }

        public List<Produit2> GetAllProduit2(SqlConnection cnx)
        {
            return dao.GetAll(cnx);
        }

        public Produit2 GetById(int id, SqlConnection cnx)
        {
            return dao.GetById(id, cnx);
        }

        public void AddProduit2(Produit2 p, SqlConnection cnx)
        {
            dao.Insert(p, cnx);
        }

        public void UpdateProduit2(Produit2 p, SqlConnection cnx)
        {
            dao.Update(p, cnx);
        }
    }
}
