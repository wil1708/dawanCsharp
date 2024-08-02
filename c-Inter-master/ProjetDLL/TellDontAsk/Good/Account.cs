using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.TellDontAsk.Good
{
    public class Account
    {
        public int Id { get; set; }
        public double Soldes { get; set; }

        public void Retrait(double montant)
        {
            if (Soldes < montant )
            {
                throw new Exception("Solde est insuffisant.....");
            }

            Soldes -= montant;
        }
    }
}
