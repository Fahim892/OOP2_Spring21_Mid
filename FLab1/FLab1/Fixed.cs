using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLab1
{
    class Fixed : Account
    {
        public int openingYear { get; set; }
        public int fixedYear { get; set; }

        public Fixed(string accountName, string accountNo, double balance, int openingYear, int fixedYear) : base(accountName, accountNo, balance)
        {
            this.openingYear = openingYear;
            this.fixedYear = fixedYear;
        }

        public override void Withdraw(double amount)
        {
            int today = DateTime.Now.Year;
            if (today - openingYear > fixedYear)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("this account is not valid for withdrawn");
            }
        }

        public override void Transfer(Account account, double amount)
        {
            int today = DateTime.Now.Year;
            if (today - openingYear > fixedYear)
            {
                Balance -= amount;
                account.Balance += amount;
            }
            else
            {
                Console.WriteLine("this account is not valid for Transfer");
            }
        }
    }
}
