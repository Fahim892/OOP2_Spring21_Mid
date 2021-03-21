using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTask2
{

    abstract class Account
    {

        public string AccountName { get; set; }
        public string AccountNo { get; }
        public double Balance { get; set; }
        public Account() { }

        public Account(string accountName, string accountNo, double balance)
        {
            AccountName = accountName;
            AccountNo = accountNo;
            Balance = balance;
        }

        abstract public void ShowInfo();


        abstract public void Deposit(double amount);

        abstract public void Withdraw(double amount);

        abstract public void Transfer(Account a, double amount);



    }
}
