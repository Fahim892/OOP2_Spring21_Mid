﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLab1
{
    class Savings : Account
    {

        public Savings(string AccountName, string AccountNo, double balance) : base(AccountName, AccountNo, balance) { }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance - 500)
            {
                Balance -= amount;
                Console.WriteLine("Your account debited by {0} to self", amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance, min balance 500");
            }

        }

        public override void Transfer(Account account, double amount)
        {
            if (amount <= Balance - 500)
            {
                Balance -= amount;
                account.Balance += amount;
                Console.WriteLine("your account transfer by {0} to the account {1}({2})", amount, account.AccountName, account.AccountNo);
            }
            else
            {
                Console.WriteLine("Insufficient balance, min balance 500");
            }
        }
    }
}
