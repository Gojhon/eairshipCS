using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample44
{
    class Parent
    {
        public int num;
        public Parent()
        {
            Console.WriteLine("부모 클래스의 생성자가 호출되었습니다.");
        }
    }
    class Child:Parent
    {
        public Child(int num)
        {
            this.num = num;
            Console.WriteLine("자식의 클래스의 생성자가 호출되었습니다.");
        }
        public void DisplayValue()
        {
            Console.WriteLine("num의 값은 {0}입니다..", num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child cd = new Child(20);
            cd.DisplayValue();

        }
    }
}
