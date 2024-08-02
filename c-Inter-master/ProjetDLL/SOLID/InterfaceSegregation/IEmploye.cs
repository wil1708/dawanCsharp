using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.InterfaceSegregation
{
    public interface IEmploye
    {
        List<Employe> getAll();
        Employe getById(int id);
        void Delete(int id);
        DateTime getDateEmbauche();
        string getContratType();
        void Update(Employe e);
        void Insert(Employe e);
    }
}
