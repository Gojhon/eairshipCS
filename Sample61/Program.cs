using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample61
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Book = new Stack();

            Book.Push("거침없이 배우는 Unity 3D");
            Book.Push("악성 코드와 멀웨어 포렌식");
            Book.Push("강행돌파! 입문자를 위한 아이폰 & 아이패드 앱 개발");
            Book.Push("오라클 엑사데이터 Oracle Exadata");

            while (Book.Count>0)
            {
                Console.WriteLine(Book.Pop());
            }

        }
    }
}
