using ProjetWinform.DAO;
using ProjetWinform.Metier;
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
        //Dependance: service depends de DAO
        IProduit dao; 

        //Injection de dependances
        public ProduitService(IProduit dao)
        {
            this.dao = dao;
        }

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

        public List<Produit> getByMinAndMax(double min, double max, SqlConnection cnx)
        {
            List<Produit> lst = new List<Produit>();

            List<Produit> allProducts = dao.getAll(cnx);
            foreach (var p in allProducts)
            {
                if(p.Prix >= min && p.Prix <= max)
                {
                    lst.Add(p);
                }
            }

            return lst;
        }
        
    }
}
