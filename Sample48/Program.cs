using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample48
{
    class Parent
    {
        public int x = 100;
        public void A()
        {
            Console.WriteLine("부모 클래스의  A()메서드 호출 !");
        }
    }

    class Child : Parent
    {
        public new int x = 200;
        public new void A()
        {
            Console.WriteLine("자식 클래스(Child)의 A() 메서드 호출!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.A();
            Console.WriteLine("x:{0}",parent.x);

            Child child = new Child();
            child.A();
            Console.WriteLine("x:{0}", child.x);
        }
    }
}
