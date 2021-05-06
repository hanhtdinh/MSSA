using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Student Info App.");
            Console.WriteLine("**************************************************************");
            Student student1 = new Student();
            Console.WriteLine("Please enter student ID.");
            student1.studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student's first name.");
            Console.ReadLine();
            Console.WriteLine("Please enter student's last name.");
            Console.ReadLine();
            Console.WriteLine("Please enter student's letter grade.");
            Console.ReadLine();

        }
    }
}
