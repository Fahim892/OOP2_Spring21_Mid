using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationLabTask1
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        private string id;


        public string ID
        {
            get { return id; }
            set { id = value; }

        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        Department department;

        public Department Department
        {
            get { return department; }
            set { department = value; }
        }
        public Student() { }
        public Student(string name, string id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
        public void Showinfo()
        {
            Console.WriteLine("Name:" +name );
            Console.WriteLine( "Id:" +id);
            Console.WriteLine( "Cgpa:" + cgpa);
        }
    }
}
      
