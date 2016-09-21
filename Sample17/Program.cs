using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 50;

            if (a < b)
                Console.WriteLine("b가 a보다 큽니다.");
            else if (a == b)
                Console.WriteLine("a와 b는 서로 같습니다.");
            else
                Console.WriteLine("a가 b보다 큽니다.");

        }
    }
}
