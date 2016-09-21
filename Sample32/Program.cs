using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample32
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 40;

            Add(ref a, 100);
            Console.WriteLine("a={0}", a);

            Add(ref a, 200);
            Console.WriteLine("a={0}", a);

            Add(ref a, 300);
            Console.WriteLine("a={0}", a);
        }

        static void Add(ref int a, int b)
        {
            a += b; // a = a + b;
        }
    }
}
