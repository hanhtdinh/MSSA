using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbersApp
{
    class Program
    {
        static void ReturnEvenNumbers() //creating a method
        {
            for(int i=1; i<=100; i++) //iterate from this range, ++ means increasing
            {
                if(i%2==0) //checks if remainder is = to 0
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Let's return all even numbers from 0-100: \t");

            ReturnEvenNumbers();
            
            
            Console.ReadKey();
        }

        
    }
}
