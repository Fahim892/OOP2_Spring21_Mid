using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationLabTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Civil Engg", "CE");
            Department d2 = new Department("CSE Engg", "Cs");
            Student s1 = new Student("MD Fahim", "a121", 3.26f);
            s1.Department = d1;
            s1.Showinfo();
            
            Console.WriteLine(s1.Department.Name);


        }
    }
}
