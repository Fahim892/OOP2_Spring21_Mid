using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLab1
{
     abstract class Account
    {
        public string AccountName { get; set; }
        public string AccountNo { get; set; }
        public double Balance { get; set; }

        public Account() { }
        public Account(string accountName, string accountNo, double balance)
        {
            AccountName = accountName;
            AccountNo = accountNo;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("your account credited by {0}. Current balance: {1}", amount, Balance);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Account Name: " + AccountName);
            Console.WriteLine("Account Number: " + AccountNo);
            Console.WriteLine("Current Balance: " + Balance);
            Console.WriteLine();
        }

        public abstract void Withdraw(double amount);
        public abstract void Transfer(Account acc, double amount);
    }
}
