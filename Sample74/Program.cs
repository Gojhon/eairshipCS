using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample74
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 4, 6, 5, 9, 8, 12, 15, 18, 17, 11, 22 };
            var data = from num in numbers
                       where num % 2 == 0
                       orderby num
                       select num;
            foreach (var i in data)
                Console.Write("{0} ", i);

        }
    }
}
