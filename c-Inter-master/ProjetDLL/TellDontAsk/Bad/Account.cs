using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.TellDontAsk.Bad
{
    public class Account
    {
        public int Id { get; set; }
        public double Solde { get; set; }

        public Account(int id, double solde)
        {
            Id = id;
            Solde = solde;
        }
    }
}
