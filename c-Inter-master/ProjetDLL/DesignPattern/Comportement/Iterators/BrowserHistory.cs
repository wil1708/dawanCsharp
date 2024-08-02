using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Comportement.Iterators
{
    public class BrowserHistory
    {
        public List<string> Urls { get; set; }

        public BrowserHistory()
        {
            Urls = new List<string>();
      
        }

        public void Push(string url)
        {
            Urls.Add(url);
        }

        public string pop()
        {
            return Urls.Last();
        }

        public Iterator CreateIterator()
        {
            return new ListIterator(this);
        }

    }
}
