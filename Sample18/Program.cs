using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample18
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 50;
            if (a > 0)
            {
                Console.WriteLine("a는 양수입니다.");
                if (a > 30)
                    Console.WriteLine("a는 30보다 큽니다.");
            }
            else
                Console.WriteLine("a는 양수가 아닙니다.");
        }
    }
}
