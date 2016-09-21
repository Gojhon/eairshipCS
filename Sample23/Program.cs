using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample23
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 2; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                }
            }
        }
    }
}
