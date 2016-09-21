using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample39
{
    class A
    {
        protected int x = 123;
    }
    class Program :A
    {
        static void Main(string[] args)
        {
            A a = new A();
            Program b = new Program();

            b.x = 10;
            Console.WriteLine(b.x);

        }
    }
}
