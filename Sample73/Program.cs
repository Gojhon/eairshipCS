using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample73
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            int[] number = { 1, 3, 4, 6, 5, 9, 8, 12, 15, 18, 17, 11, 22 };

            foreach (int num in number)
            {
                if (num % 2 == 0)
                    intList.Add(num);
            }
            intList.Sort();

            foreach (int num in intList)
                Console.WriteLine("{0}", num);

        }
    }
}
