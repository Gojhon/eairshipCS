using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample25
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while(num<100)
            {
                if (num == 40) break;
                Console.WriteLine("num:" + num);
                num++;

            }
        }
    }
}
