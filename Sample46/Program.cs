using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample46
{
    public class MyClass
    {
        private string name = "John";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 5)
                    name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MyClass mc = new MyClass();

            Console.WriteLine("mc.Name : {0}", mc.Name);

            mc.Name = "Kelley";

            Console.WriteLine("mc.Name : {0}", mc.Name);
        }
    }
}
