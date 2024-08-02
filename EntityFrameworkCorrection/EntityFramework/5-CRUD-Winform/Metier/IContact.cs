using _5_CRUD_Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CRUD_Winform.Metier
{
    public interface IContact
    {
        List<Contact> getAll();
        void Insert(Contact c);
        void Update(Contact c);
        void Delete(int id);
        Contact findById(int id);
    }
}
