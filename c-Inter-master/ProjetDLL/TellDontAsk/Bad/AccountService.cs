using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.TellDontAsk.Bad
{
    public class AccountService
    {
        private AccountRepository repo;

        //Méthode de retrait
        public void Retrait(int accountId, double montant)
        {
            Account  c = repo.findById(accountId);
            if (c.Solde < montant)
            {
                throw new Exception("Error: not enough money!");
            }
            c.Solde -= montant;
            repo.save(c);
        }
    }
}
