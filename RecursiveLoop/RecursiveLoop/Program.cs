using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int revalue= Printer(2);
            Console.WriteLine("Return value of Printer(2):{0}", revalue);
            Console.ReadKey();
        }
        private static int Printer(int j)
        {
            for (var i = j; i > 0; i = Printer(i - 1))
            {

                Console.Write(i);
            }
            return j;
        }
    }
}
