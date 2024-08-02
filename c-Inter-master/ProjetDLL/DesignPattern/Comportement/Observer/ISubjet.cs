using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Comportement.Observer
{
    public interface ISubjet
    {
        void Attach(IObserver obj);
        void Detach(IObserver obj);
        void Notify(ISubjet obj);
    }
}
