using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Comportement.Observer
{
    public class ProductItem : ISubjet
    {
        public int Id { get; set; }
        public string Description { get; set; }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; Notify(this); }
        }

        public List<IObserver> Observers { get; set; }

        public ProductItem()
        {
            Observers = new List<IObserver>();
        }

        public void Attach(IObserver obj)
        {
            if (!Observers.Contains(obj))
            {
                Observers.Add(obj);
            }
        }

        public void Detach(IObserver obj)
        {
            Observers.Remove(obj);
        }

        public void Notify(ISubjet obj)
        {
            foreach (IObserver obs in Observers)
            {
                obs.Update(obj);
            }
        }
    }
}
