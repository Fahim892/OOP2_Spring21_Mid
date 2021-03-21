using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLab1
{
    class Customer
    {
        public string Name { get; set; }
        Account[] accounts;
        public int Account;
        public Customer(string name)
        {
            Name = name;
            accounts = new Account[10];
        }

        public void AddAccount(params Account[] accounts)
        {
            foreach (Account account in accounts)
            {
                this.accounts[Account++] = account;
            }
        }

        public void AccDetails()
        {
            Console.WriteLine("Customer name: " + Name);

            for (int i = 0; i < Account; i++)
            {
                accounts[i].ShowInfo();
            }
        }

        public Account findAccount(string accountNo)
        {
            Account account = null;
            for (int i = 0; i < Account; i++)
            {
                if (accountNo.Equals(accounts[i].AccountNo))
                {
                    account = accounts[i];
                    break;
                }
            }
            return account;
        }
    }
}