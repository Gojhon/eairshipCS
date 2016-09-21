#define TEST

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace Sample66
{
    class Program
    {
        // TEST가 정의되어 있어야만 호출이 가능합니다.
        [Conditional("TEST")]
        public void TestConditional()
        {
            Console.WriteLine("TestConditional!");
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            program.TestConditional();
        }
    }
}
