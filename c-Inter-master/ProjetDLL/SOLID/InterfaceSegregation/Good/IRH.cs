using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.InterfaceSegregation.Good
{
    public interface IRH  
    {
        string getContratType();
        DateTime getDateEmbauche();
        List<Employe> getAll();
    }
}
