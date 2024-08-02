using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Creation.Prototype
{
    public class CartLine : ICloneable
    {
        public LineArticle Article { get; set; }
        public int Qty { get; set; }

        public object Clone()
        {
            CartLine cartLine = (CartLine)this.MemberwiseClone();
            cartLine.Article = (LineArticle)this.Article.Clone();

            return cartLine;
        }

        public override string ToString()
        {
            return "CartLine: " + Article.ToString() + " Quantity: " + Qty;
        }
    }
}
