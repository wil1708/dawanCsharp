using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assertion
{
    public class Employe
    {
        public string Name { get; set; }

        public Employe(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            return obj is Employe employe &&
                   Name == employe.Name;
        }
    }

    public class Technicien : Employe
    {
        public Technicien(string name) : base(name)
        {
            
        }
    }
}
