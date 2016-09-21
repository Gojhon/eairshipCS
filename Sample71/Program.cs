using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Sample71
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsa = File.Create("a.txt");
            FileInfo file = new FileInfo("b.txt");
            FileStream fsb = file.Create();

            fsa.Close();
            fsb.Close();
            File.Copy("a.txt", "c.txt");
            FileInfo dst = file.CopyTo("d.txt");
        }
    }
}
