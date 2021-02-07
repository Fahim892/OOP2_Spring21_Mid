using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLab
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;
        public int X
        {
            get { return x; }
            set { x = value; }
            }
            public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        internal void Triangle()
        {
            if (x==y && y==z && z == x)
            {
                Console.WriteLine("equilateral Triangle");
            }
            else if (x==y|| y == z || z == x)
            {
                Console.WriteLine("Isosecles Triangle");
            }
        }
        internal void ShowInfo()
        {
            Console.WriteLine("X:" + x);
            Console.WriteLine("Y:" + y);
                Console.WriteLine("Z:" + z);
        }
        static void Main()
        {
            Triangle t = new Triangle();
            t.x = 12;
            t.y = 12;
            t.y = 24;
            t.ShowInfo();
            Console.WriteLine("Triangle :");
            t.Triangle();
        }

        }
    }
}
