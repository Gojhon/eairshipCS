using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample42
{
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("매개변수가 없는 디폴트 생성자");
        }
        public MyClass(int a)
        {
            Console.WriteLine("정수형 매개변수");
        }
        public MyClass(double d)
        {
            Console.WriteLine("실수형 매개변수");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ma = new MyClass();
            MyClass mb = new MyClass(10);
            MyClass mc = new MyClass(25.5);

        }
    }
}
