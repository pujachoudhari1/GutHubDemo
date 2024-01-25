using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add();
            sub();
       }
        public static void add()
        {
            int x = 45, y = 5, z;
            z = x + y;
            Console.WriteLine("Add is : "+ z);

            Console.WriteLine(z);
        }
        public static void sub()
        {
            int x = 45, y = 5, z;
            z = x - y;
            Console.WriteLine("Add is : " + z);

            Console.WriteLine(z);
        }
    }
}
