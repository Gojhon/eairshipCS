using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample75
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = "str12i3!@$1ng".ToCharArray();
            var data = from vchar in chars
                       where vchar >= 97 && 122 >= vchar
                       select vchar;

            foreach (char i in data)
                Console.Write("{0}", i);
        }
    }
}
