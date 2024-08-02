using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Creation.Builder
{
    public class BankAccountBuilder : BankAccount
    {
        public BankAccountBuilder withNumber(long number)
        {
            accountNumber = number;
            return this;
        }

        public BankAccountBuilder withNameAndPassword(string name, string password)
        {
            Name = name;
            Password = password;
            return this;
        }

        public BankAccountBuilder AccountIsLocker(bool locked)
        {
            isLocked = locked;
            return this;
        }

        public BankAccountBuilder withLoad(double amount, float interest)
        {
            loanAmount = amount;
            interestRate = interest;
            return this;
        }

        public BankAccountBuilder accountIsLoanInsured(bool insured)
        {
            isInsured = insured;
            return this;
        }

        public BankAccountBuilder Build()
        {
            return this;
        }
    }
}
