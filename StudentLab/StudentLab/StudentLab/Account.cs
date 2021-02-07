using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLab
{
    class Account
    {
        private String accountName;
        private String accountid;
        private int balance;
        public String AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        public String AccountId
        {
            get { return accountid; }
            set { accountid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        internal void Deposit(int amount)
        {
            balance = balance + amount;
        }
        internal void Withdraw(int amount)
        {
            balance = balance - amount;
        }
        internal void ShowInfo()
        {
            Console.WriteLine("Account Name : " + accountName);
            Console.WriteLine("Account ID : " + accountid);
            Console.WriteLine("Balance : " + balance);
        }
        static void Main()
        {
            Account c = new Account();
            c.accountName = "X";
           c.accountid = "1";
            c.balance = 10000;
            c.Deposit(1000);
            c.Withdraw(500);
            c.ShowInfo();
        }
    }



