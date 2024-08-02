using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.TellDontAsk.Good
{
    public class AccountService : IAccountService
    {
        private AccountRepository repo;

        public void Retrait(int accountId, double montant)
        {
            Account c = repo.findById(accountId);
            c.Retrait(montant);
            repo.Save(c);
        }
    }
}
