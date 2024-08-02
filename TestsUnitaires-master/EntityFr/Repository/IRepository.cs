using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFr.Repository
{
    public interface IRepository
    {
        List<Contact> getAll();
        void Insert(Contact c);
        void Delete(int id);
        Contact findById(int id);
        void Update(Contact c);
    }
}
