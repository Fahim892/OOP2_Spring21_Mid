using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            Console.WriteLine("Even Numbers from 1 to " + n + " are :");
            for (int i =1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "");
                }
            }


        }
    }
}
