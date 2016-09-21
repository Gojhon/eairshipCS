using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample43
{
    class MyClass
    {
        private string name;

        public MyClass(string name)
        {
            this.name = name;
            Console.WriteLine(name + "객체생성!");
        }
        ~MyClass()
        {
            Console.WriteLine(name + "객체 소멸!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ma = new MyClass("a");
            MyClass mb = new MyClass("b");
            MyClass mc = new MyClass("c");

        }
    }
}
