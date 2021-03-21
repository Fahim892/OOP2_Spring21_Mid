using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Ahsan = new Savings("Ahsan", "001", 600.0f);
            Account Habib = new Current("Habib", "002", 500f);
            Account Fahim  = new Fixed("Fahim", "003", 1000f, 2018, 35);

            Account ss = new SuperSavings("Rony", "004", 400f);
            ss.Withdraw(80);
            ss.ShowInfo();

            Account overdraft = new Overdraft("Shohan", "005", 1000f, 5000);
            overdraft.Transfer(ss, 5000);
            overdraft.ShowInfo();

            Customer customer = new Customer("Ahsan abib");

          
        }
    }
}
