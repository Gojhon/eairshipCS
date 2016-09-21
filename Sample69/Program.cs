using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Sample69
{

   
    class Program
    {
        [CustomAttribute("str",vartmp ="TMP")]
        static void Main(string[] args)
        {
            Console.WriteLine("CustomAttribute!");
        }
    }
    class CustomAttribute : System.Attribute
    {
        private string str;
        private string tmp;

        public CustomAttribute(string str)
        {
            this.str = str;
        }
        public string vartmp
        {
            get
            {
                return tmp;
            }
            set
            {
                tmp = value;
            }
        }
    }
}
