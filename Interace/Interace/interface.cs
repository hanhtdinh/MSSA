using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interace
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Math calc = new Math(); //need to make instance of class, not instance of interface to use our methods
            //you cannot instantiate an interface
           
            Console.ForegroundColor = ConsoleColor.Green; //changing text colors
            Console.WriteLine("Welcome to ICalculator, a new revolutionary application made by GreenApple Inc \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            calc.addNumbers();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            calc.subNumbers();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            calc.divNumbers();
            Console.ForegroundColor = ConsoleColor.Red;
            calc.multNumbers();


            Console.ReadLine();
        }
        
    }
}
