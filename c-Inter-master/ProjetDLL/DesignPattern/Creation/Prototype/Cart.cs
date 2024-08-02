using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Creation.Prototype
{
    public class Cart : ICloneable
    {
        public List<CartLine> Lines { get; set; }

        public object Clone()
        {
            Cart cart = (Cart)this.MemberwiseClone();
            
            cart.Lines = new List<CartLine>();

            foreach (CartLine line in Lines)
            {
                cart.Lines.Add((CartLine)line.Clone());
            }
            return cart;
        }

        public override string ToString()
        {
            string list = "";
            foreach (CartLine line in Lines)
            {
                list += line.ToString();
            }

            return "Contenu: "+list;
        }
    }
}
