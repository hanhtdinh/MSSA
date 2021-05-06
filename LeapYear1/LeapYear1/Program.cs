using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear1
{
    class Program
    {
        public static int year;
        //reason why it is static is so that it can be accessible in our static method
        static void calcYear() //is void b/c no return type
        {

            if (year % 4 == 0) //first check
            {
                if ((year % 100 == 0) && (year % 400 != 0))
                    //div by 100 remainder is 0 and div by 400 remainder is not 0, for sure leap
                {
                    Console.WriteLine("\nThis is a leap year.");
                }
                if ((year % 100 == 0) && (year % 400 == 0))
                    //div by 100 and 400 remainder is 0, yes
                {
                    Console.WriteLine("\nThis is a leap year.");
                }
                else //does not meet, not leap year
                {
                    Console.WriteLine("\nThis is not a leap year.");

                }


            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Let's check if a year is a leap year. \n");
            Console.WriteLine("Insert your number as four digits: YYYY \n");
            year = Convert.ToInt32(Console.ReadLine());

            //var anInstanceofcalcYear = new calcYear();
            //anInstanceofcalcYear.calcYear();
            //did not work

            calcYear();
            //no need to use console writeline b/c method already prints the result

            Console.ReadLine();
        }


    }
}
