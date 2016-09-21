using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample40
{
    class A
    {
        private int num;
        public A(int num)
        {
            this.num = num;
        }
        public void Show()
        {
            Console.WriteLine("num: " + num);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(50);

            a.Show();
        }

    }
}
