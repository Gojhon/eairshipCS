using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample60
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("one");
            queue.Enqueue("two");
            queue.Enqueue("three");
            queue.Enqueue("four");

            while (queue.Count > 0)
                Console.WriteLine("Dequeue : {0},Count:{1}", queue.Dequeue(), queue.Count);


        }
    }
}
