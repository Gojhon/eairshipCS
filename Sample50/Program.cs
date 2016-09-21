using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample50
{
    partial class Nested
    {
        public void Test()
        {
            Console.WriteLine("Test()");
        }
    }
    partial class Nested
    {
        public void Test2()
        {
            Console.WriteLine("Test()2");
        }
    }
    partial class Nested
    {
        public void Test3()
        {
            Console.WriteLine("Test()3");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Nested nested = new Nested();
            nested.Test();
            nested.Test2();
            nested.Test3();
        }
    }
}
