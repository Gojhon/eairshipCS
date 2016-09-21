using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample36
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] reading = new int[] { 4, 9, 1, 0, 21, 12 };

            Console.WriteLine("속성 Rank={0},Length={1}", reading.Rank, reading.Length);

            Console.Write("Clear메소드");
            Array.Clear(reading, 0, 5);
            Array.ForEach<int>(reading, new Action<int>(ShowValue));
            Console.WriteLine();
        

            Console.Write("Resize 메소드: ");
            Array.Resize(ref reading, reading.Length + 3);
            Array.ForEach<int>(reading, new Action<int>(ShowValue));
            Console.WriteLine();
            Console.WriteLine("indexOf 메소드: {0}", Array.IndexOf(reading, 12));
        }
        static void ShowValue(int value) // 동작, value를 받아 그 value를 출력시킴
        {
            Console.Write("{0} ", value);
        }
    }
}
