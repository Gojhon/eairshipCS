using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;


namespace Sample67
{
    class Program
    {

        [Obsolete("OldMethod()는 더이상 사용하지 않으므로, NewMethod()를 사용해주세요.",true)]
        public void OldMethod() { Console.WriteLine("OLD!"); }

        public void NewMethod() { Console.WriteLine("NEW!"); }

        static void Main(string[] args)
        {
            Program program = new Program();

            program.OldMethod();
            program.NewMethod();
        }
    }
}
