using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample49
{
    public static class ExtensionMethod
    {
        public static int Multiplication(this int var,int a, int b)
        {
            int result = var;

            for (int i = 0; i < b; i++)
                result *= a;

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", 5.Multiplication(2, 3));
        }
    }
}
