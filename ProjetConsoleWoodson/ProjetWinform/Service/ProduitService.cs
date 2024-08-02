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

        public void deleteProduct(int id, SqlConnection cnx)
        {
            dao.deleteById(id, cnx);
        }

        public List<Produit> findBykey(string key, SqlConnection cnx)
        {
            return dao.findByKey(key, cnx);
        }

        public List<Produit> getAllProducts(SqlConnection cnx)
        {
            return dao.getAll(cnx);
        }

        public Produit findById(int id, SqlConnection cnx)
        {
            return dao.getById(id, cnx);
        }

        public void addProduct(Produit p, SqlConnection cnx)
        {
            dao.insert(p, cnx);
        }

        public void updateProduct(Produit p, SqlConnection cnx)
        {
            dao.update(p, cnx);
        }
        
    }
}
