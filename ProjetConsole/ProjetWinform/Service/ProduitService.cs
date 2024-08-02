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
    public class ProduitService
    {
        ProduitDAO dao = new ProduitDAO();
        
        public void AddProduct(Produit p, SqlConnection cnx)
        {
            dao.insert(p, cnx);
        }

        public List<Produit> FindByKey(string key, SqlConnection cnx)
        {
            return dao.findByKey(key, cnx);
        }

        public List<Produit> GetAllProducts(SqlConnection cnx)
        {
            return dao.getAll(cnx);
        }

        public void DeleteProduct(int id, SqlConnection cnx)
        {
            dao.deleteById(id, cnx);
        }

        public Produit FindById(int id, SqlConnection cnx)
        {
            return dao.getById(id, cnx);
        }

        public void UpdateProduct(Produit p, SqlConnection cnx)
        {
            dao.update(p, cnx);
        }
    }
}
