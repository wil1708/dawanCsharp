using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Comportement.Iterators
{
    public interface Iterator
    {
        bool hasNext();
        string Current();
        void Next();
    }
}
