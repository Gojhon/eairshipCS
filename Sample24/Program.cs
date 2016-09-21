using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample24
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;


            while (true)
            {
                Console.Write("수를 입력하세요: ");
                string line = Console.ReadLine(); // 값을 입력받는 부분!
                if (line == "end") break; // end가 입력되면 무한 루프를 빠져나온다.
                sum += int.Parse(line); // 문자열을 숫자로 변환한다!
            }

            Console.WriteLine("지금까지 입력된 수를 모두 더합니다: " + sum);
        }
    }
}
