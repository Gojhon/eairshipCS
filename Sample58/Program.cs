using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample58
{
    class Program
    {
        static void ShowArrayList(ArrayList list)
        {
            foreach (object obj in list)
                Console.Write("{0} ", obj);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
           ArrayList alist= new ArrayList();
            for(int i=0;i<10;i++)
            alist.Add(i);

            Console.WriteLine("alist:");
            ShowArrayList(alist);

            alist.Remove(5); ;
            alist.Insert(5, 20);
            ShowArrayList(alist);

        }
    }   
}
