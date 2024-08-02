using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Comportement.Iterators
{
    public class ListIterator : Iterator
    {
        public BrowserHistory history { get; set; }
        private int index;

        public ListIterator(BrowserHistory history)
        {
            this.history = history;
        }

        public string Current()
        {
            return history.Urls[index];
        }

        public bool hasNext()
        {
            return (index < history.Urls.Count);
        }

        public void Next()
        {
            index++;
        }
    }
}
