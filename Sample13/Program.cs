using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50, b = 60;

            a += b;
            Console.WriteLine(a);
            a -= b;
            Console.WriteLine(a);
            a *= b;
            Console.WriteLine(a);
            a %= b;
            Console.WriteLine(a);

        }
    }
}
