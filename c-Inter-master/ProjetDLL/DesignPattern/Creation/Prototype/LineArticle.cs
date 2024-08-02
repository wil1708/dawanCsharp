using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Creation.Prototype
{
    public class LineArticle : ICloneable
    {
        public string Description { get; set; }
        public double Price { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "Description: " + Description + " Price: " + Price;
        }

        public LineArticle(string description)
        {
            Description = description;
        }

        public LineArticle()
        {
        }
    }
}
