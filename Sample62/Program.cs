using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample62
{
    delegate int PDelegate(int a, int b);

    class Program
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            PDelegate pd1 = Plus;
            PDelegate pd2 = delegate (int a, int b) { return a / b; };

            Console.WriteLine(pd1(5, 10));
            Console.WriteLine(pd2(10, 5));



        }
    }
}
