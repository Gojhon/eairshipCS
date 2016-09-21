using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Sample68
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int MessageBox(int hParent, string Messgae, string Caption, int Type);

        static void Main(string[] args)
        {
            int j=MessageBox(0, "DllImport!", "DllImport", 1);
            Console.WriteLine(j);
        }
    }
}
