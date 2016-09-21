using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", Add(50, 10));
            Console.WriteLine("{0}", Add(544.2, 63.2));
            Console.WriteLine("{0}", Add(4, 7, 9));
        }

        static int Add(int a, int b)
        {
            Console.WriteLine("두 int형 끼리의 덧셈");
            return a + b;
        }

        static double Add(double a, double b)
        {
            Console.WriteLine("두 double형 끼리의 덧셈");
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            Console.WriteLine("세 int형 끼리의 덧셈");
            return a + b + c;
        }
    }
}
