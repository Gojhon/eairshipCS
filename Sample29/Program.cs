using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample29
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 40;
            int b = 10;

            Console.WriteLine("Swap before : a={0},b={1}", a, b);
            Swap(a, b);
            Console.WriteLine("Swap after  : a={0},b={1}", a, b);
        }

        static void Swap(int a,int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}
