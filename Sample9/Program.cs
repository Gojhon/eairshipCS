using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 500;
            float b = 60.44f;
            string c = a.ToString();
            string d = b.ToString();

            Console.WriteLine("a={0},b={1},c={2},d={3}",a,b,c,d);

            string e = "132";
            string f = "123.456";
            int g=int.Parse(e);
            float h = float.Parse(f);

            Console.WriteLine("e={0},f={1},g={2},h={3}",e,f,g,h);

        }
    }
}
