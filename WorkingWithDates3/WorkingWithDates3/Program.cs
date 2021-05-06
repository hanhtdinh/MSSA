using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDates3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call withWorkDateTime method
            WorkWithDateTime();
            //Press any key to exit
            Console.ReadKey();
        }
        static void WorkWithDateTime()
        {
            //Declaring a DateTime variable
            //Setting year, month, day parameters - parameteres are all of type int:
            DateTime date1 = new DateTime(2019, 8, 13);
            //Setting year, month, day,hour, minute, seconds - parameters are all of type int:
            DateTime date2 = new DateTime(2019, 8, 13, 14, 15, 45);
            //Write output to the Console.
            //{0} and {1} in the output string refers to the first
            //and 2nd variables listed after the string:
            Console.WriteLine("DateTime : date1 value: {0}, date2 value: {1}.", date1, date2);
            {
                //Call WorkWithDateTimeOffset method
                //Create a DateTimeOffset object that is set 
                //to the current date and time on the current
                //computer, with the offset set to the local time's
                //offset from UCT(coordinated Universal Time)
                DateTimeOffset dateOffset1 = DateTimeOffset.Now;
                Console.WriteLine("Adds Difference (offset) between the current date and UTCNow: {0}", dateOffset1);

            static void WorkingWithTimeSpan()
                {
                    //Determine your total trip time
                    DateTime departToDestination = new DateTime(2019, 8, 28, 8, 15, 0);
                    DateTime arriveFromDestination = new DateTime(2019, 9, 1, 10, 20, 0);
                    TimeSpan tripTime = arriveFromDestination - departToDestination;
                    Console.WriteLine("Total time of Trip:{2}", arriveFromDestination, departToDestination, tripTime);
                    //Call WorkWithTimeSpan method
                    WorkingWithTimeSpan();
                }

            }
        }
    }
}
