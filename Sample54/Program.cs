using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample54
{
    interface ParentInterface
    {
        void myMethod(string str);
    }
    interface SubInterface: ParentInterface
    {
        void myMethod(string str, int i);
    }
    class MyClass : SubInterface
    {
       public void myMethod(string str)
        {
            Console.WriteLine(str + " ParentInterface.myMethod() call!");
        }
        public void myMethod(string str, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(str + " SubInterface.myMethod() " + i + " call!");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass sif = new MyClass();

            sif.myMethod("Interface");
            sif.myMethod("Inherits", 4);
        }
    }
}
