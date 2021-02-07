using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLab
{
    class Student
    {
        
        
            private String id;
            private String name;
        private String department;
        private float cgpa;
        public String Id
        {
            get { return id; }
            set { id = value; }

        }
        public String Name
        {
            get { return name; }
            set { name = value; }

        }
        public String Department
        { 
            get { return department; }
            set { name = value; }
        }
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        internal void Showinfo()
        {
            Console.WriteLine("Id" + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Department" + department);
            Console.WriteLine("Cgpa" + cgpa);

        }
        static void Main()
        {
            Student s = new Student();
            s.name = "Fahim";
            s.id = "18-38396-2";
            s.department = "Cse";
            s.cgpa = 3.26f;
            s.Showinfo();
        }

        

        
            



        }
    }
}
