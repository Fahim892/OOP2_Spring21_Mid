using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTask2

{
    class OverDraft : Account
    {
        public int Limit { get; set; }
        public OverDraft()
        {

        }
        public OverDraft(string accountName, string accountNo, double balance, int limit) : base(accountName, accountNo, balance)
        {
            Limit = limit;
        }

        public override void Deposit(double amount)
        {
            Balance = Balance + Limit + amount;
            Console.WriteLine("Your acc is credited by {0} to self and updated  balance is {1} ", amount, Balance);
        }
        public override void Withdraw(double amount)
        {
            if (amount <= (Balance + Limit))
            {
                Balance = Balance - amount;
                Console.WriteLine("Your acc is debited by {0} and updated  balance is {1} ", amount, Balance);
            }
            else
            {

                Console.WriteLine("Insuffient Balance maximum amount you can withdraw is:" + (Balance + Limit));
            }
        }
        public override void Transfer(Account a, double amount)
        {
            if (amount <= (Balance + Limit))
            {
                Balance = Balance - amount;


                Console.WriteLine("You account is debited by {0} new balance {1} and credited to  account: {2} ({3})", amount, Balance, a.AccountName, a.AccountNo);
            }
            else
            {
                Console.WriteLine("Insuffient Balance maximum amount you can transfer is:" + (Balance + Limit));
            }

        }

        public override void ShowInfo()
        {
            Console.WriteLine("Name: " + AccountName);
            Console.WriteLine("Acc No: " + AccountNo);

        }


    }

}