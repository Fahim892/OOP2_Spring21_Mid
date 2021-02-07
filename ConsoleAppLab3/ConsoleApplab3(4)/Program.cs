using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplab3_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num, odd_sum = 0, even_sum = 0;
            Console.WriteLine("Enter the value of num\n");
            
            for (i =1; i<=num; i++)
            {
                if (i % 2 == 0)
                    even_sum = even_sum + i;
                else
                    odd_sum = odd_sum + i;

            }
            Console.WriteLine("Sum of all odd numbers = n", odd_sum);
            Console.WriteLine("Sum of all even numbers = n", even_sum);

        }
    }
}
