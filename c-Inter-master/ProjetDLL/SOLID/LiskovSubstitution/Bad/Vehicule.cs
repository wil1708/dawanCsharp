﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.SOLID.LiskovSubstitution.Bad
{
    public class Vehicule
    {
        public virtual void Demarrer()
        {
            Console.WriteLine("Véhicule démarré..............");
        }
    }
}
