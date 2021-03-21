using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLab1
{
    class SuperSavings : Account
    {
        public double openingAmount { get; set; }
        public SuperSavings(string accountName, string accountNo, double balance) : base(accountName, accountNo, balance)
        {
            this.openingAmount = balance;
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance - (openingAmount * 20 / 100))
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Not sufficient fund. Min amount " + openingAmount * 20 / 100);
            }
        }

        public override void Transfer(Account account, double amount)
        {
            if (amount <= Balance - (openingAmount * 20 / 100))
            {
                Balance -= amount;
               account.Balance += amount;
            }
            else
            {
                Console.WriteLine("Not sufficient fund. Min amount " + openingAmount * 20 / 100);
            }
        }
    }
}
