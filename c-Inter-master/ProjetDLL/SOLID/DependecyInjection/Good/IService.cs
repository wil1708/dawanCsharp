using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.DependecyInjection.Good
{
    public interface IService
    {
        object TraiterUser(int id);
    }
}
