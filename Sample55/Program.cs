using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Division(5, 0));
            Console.WriteLine(Division(10, 2));
            Console.WriteLine(Division(49, 7));
        }

        static int Division(int a,int b)
        {
            try
            {
                return a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
}
