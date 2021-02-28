using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationLabTask1
{
    class Department
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
        public Department()
        {

        }
        public Department(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public void Showinfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("ID:" + id);
        }
    }
    

    
}
