using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Agregation.forte
{
    public class Moteur
    {
        public String Motorisation { get; set; }

        public Moteur(string motorisation)
        {
            Motorisation = motorisation;
        }
    }
}
