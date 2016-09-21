using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample59
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            table.Add("사과", "apple");
            table.Add("토마토", "tomato");
            table["감자"] = "potato";

            foreach (object obj in table.Keys)
            Console.WriteLine("{0}: {1}", obj, table[obj]);
        }
    }
}
