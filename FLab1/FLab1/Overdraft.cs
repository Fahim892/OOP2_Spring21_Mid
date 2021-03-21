using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLab1
{
    class Overdraft :Account
    {
        public int limit { get; set; }

        public Overdraft() { }
        public Overdraft(string accountName, string accountNo, double balance, int limit) : base(accountName, accountNo, balance)
        {
            this.limit = limit;
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance + limit)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Not sufficient fund.");
            }
        }
        public override void Transfer(Account account, double amount)
        {
            if (amount <= Balance + limit)
            {
                Balance -= amount;
                account.Balance += amount;
            }
            else
            {
                Console.WriteLine("Not sufficient fund.");
            }
        }
    }
}
