using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Structure.Proxy
{
    public interface IMessages
    {
        //cette interface liste les tâches que peut effectuer un proxy
        string getContent();
    }
}
