using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample57
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Division(10, 2));
                Console.WriteLine(Division(49, 7));
                Console.WriteLine(Division(5, -1));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static int Division(int a, int b)
        {
            if (a <= 0 || b <= 0)
                throw new Exception("0 또는 음수가 오는 것을 허용하지 않습니다.");
            else
                return a / b;
        }
    }
}
