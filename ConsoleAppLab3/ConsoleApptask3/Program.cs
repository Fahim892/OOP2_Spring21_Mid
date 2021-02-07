using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApptask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int phy = 74, che = 64, bio = 91, math = 89, com = 78;

            double sum = phy + che + bio + math + com;
                sum /= 5.0;
            Console.WriteLine("percentage is " + sum + "%");
            if(sum<50)
            {
                Console.WriteLine("Failed");

            }
            else if(sum>=50 && sum<75)
            {

                Console.WriteLine("c+");

            }
            else if(sum>=75 && sum<=79)
            {
                Console.WriteLine("B");

            }
            else if(sum>=80 && sum<85)
            {
                Console.WriteLine("B+");

            }

            else if(sum>85 && sum<89)
                {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("A+");
            }
        }
    }
}
