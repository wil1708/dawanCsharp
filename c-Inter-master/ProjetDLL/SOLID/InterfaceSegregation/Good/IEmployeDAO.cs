using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.InterfaceSegregation.Good
{
    public interface IEmployeDAO
    {
        List<Employe> getAll();
        void Delete(int id);
        Employe findById(int id);
        void Update(Employe e);

    }
}
