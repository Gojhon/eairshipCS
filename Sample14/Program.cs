using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50, b = 60;

            Console.WriteLine(a > 40 && b > 50);
            Console.WriteLine(a > 40 || b > 70);
            Console.WriteLine(!(a < b));

        }
    }
}
