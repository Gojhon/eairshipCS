using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample27
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (num < 100) // num보다 100이 크면 계속 반복
            {
                if (num == 40) goto EXIT; // num이 40이면 break로 인해 반복 탈출
                Console.WriteLine("num: " + num);
                num++; // num의 값 1 증가
            }

            EXIT: // EXIT 레이블!
            Console.WriteLine("탈출!");
        
    }
    }
}
