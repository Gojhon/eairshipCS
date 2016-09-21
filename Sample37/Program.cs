using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample37
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] reading = new int[3, 6] {{ 4, 9, 1, 0, 21, 12 }, { 1, 4, 6, 0, 9, 5 }, { 4, 4, 2, 4, 0, 0 } };

            for(int i=0; i<reading.GetLength(0);i++)
                for (int j = 0; j< reading.GetLength(1); j++)
                    Console.WriteLine("reading[" + i + ", " + j + "] = {0}", reading[i, j]);

        }
    }
}
