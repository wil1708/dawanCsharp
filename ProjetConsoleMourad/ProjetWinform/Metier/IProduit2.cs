using ProjetWinform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.Metier
{
    public interface IProduit2
    {
        void insert(Produit p);
        List<Produit> findByKey(string key);
        List<Produit> getAll();
        Produit getById(int id);
        void update(Produit p);
        void deleteById(int id);
    }
}
