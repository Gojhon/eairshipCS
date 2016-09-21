using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum={0}", total(20, 10, 40, 4, 7, 6, 44, 55, 2));
            Console.WriteLine("sum={0}", total(30, 4, 5));
        }

        static int total(params int[] list)
        {
            int sum = 0;

            //for (int i = 0; i < list.Length; i++)
              //  sum += list[i];

            foreach (int i in list)
                sum += i;
            return sum;
        }
    }
}
