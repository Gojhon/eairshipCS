using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample26
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 1) continue;
                Console.WriteLine("i: " + i);
            }
        }
    }
}
