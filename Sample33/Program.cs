using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample33
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Add(out a);
            Console.WriteLine("a={0}", a);
        }

        static void Add(out int a)
        {
            a = 100;
        }
    }
}
