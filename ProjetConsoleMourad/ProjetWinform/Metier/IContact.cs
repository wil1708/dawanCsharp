using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWinform.Metier
{
    public interface IContact
    {
        List<Contact> getAll();
        void Insert(Contact c);
        void delete(Contact c);
    }
}
