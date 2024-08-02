using Shop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Logic
{
    public interface IRepository<T> where T : BaseEntity
    {
        //Le type accepte les requête LINK contrairement à une liste classique
        IQueryable<T> Collection();
        void Delete(int id);
        T FindById(int id);
        void Insert(T t);
        void SaveChanges();
        void Update(T t);
    }
}
