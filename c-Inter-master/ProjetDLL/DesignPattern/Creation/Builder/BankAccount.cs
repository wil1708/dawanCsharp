using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Creation.Builder
{
    public class BankAccount
    {
        public long accountNumber { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool isLocked { get; set; }
        public double loanAmount { get; set; }
        public float interestRate { get; set; }
        public bool isInsured { get; set; }

        public BankAccount(long accountNumber, string name, string password, bool isLocked, double loanAmount, float interestRate, bool isInsured)
        {
            this.accountNumber = accountNumber;
            Name = name;
            Password = password;
            this.isLocked = isLocked;
            this.loanAmount = loanAmount;
            this.interestRate = interestRate;
            this.isInsured = isInsured;
        }

        public BankAccount(long accountNumber, string name, string password)
        {
            this.accountNumber = accountNumber;
            Name = name;
            Password = password;
        }

        public BankAccount(long accountNumber, string name, string password, double loanAmount) : this(accountNumber, name, password)
        {
            this.loanAmount = loanAmount;
        }

        public BankAccount()
        {
        }
    }
}
