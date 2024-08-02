using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.InterfaceSegregation.Good
{
    public class EmployeDAO : IEmployeDAO
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employe findById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employe> getAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Employe e)
        {
            throw new NotImplementedException();
        }
    }
}
