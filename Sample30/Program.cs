using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample30
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 40;
            int b = 10;

            Console.WriteLine("Swap before : a={0},b={1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("Swap after  : a={0},b={1}", a, b);
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}
