using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Sample56
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sreader = null;
            StreamWriter swriter = null;

            try
            {
                sreader = new StreamReader(File.Open("A.txt", FileMode.Open));
                swriter = new StreamWriter(File.Open("B.txt", FileMode.Append, FileAccess.Write));

                while (sreader.Peek() != -1)
                {
                    swriter.WriteLine(sreader.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sreader != null) sreader.Close();
                if (swriter != null) swriter.Close();
            }

        }
    }
}
