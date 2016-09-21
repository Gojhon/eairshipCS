using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 500;
            float b = (float)a;

            Console.WriteLine("a={0},b={1}", a, b);

            double c = 123.45;
            int d = (int)c;

            Console.WriteLine("c={0},d={1}", c, d);
        }
    }
}
