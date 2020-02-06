/* 
 Widler Rislin
 9/11/2019
 CEN 4370C
 Module 2 Assignment
 This Program reads in 5 numbers from a user then outputs their sum and average 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number, then press Enter: "); // Outout that ask user to input first of five numbers
            double a = double.Parse(Console.ReadLine()); // Reads in and stores users number in declared double
            Console.Write("Please enter the second number, then press Enter: "); 
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter the third number, then press Enter: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Please enter the fourth number, then press Enter: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Please enter the fifth number, then press Enter: ");
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double sum = a + b + c + d + e; // Sum total of number stored in double sum.
            double m = Math.Round((sum / 5),2); // Average of the numbers rounded to 2 decimal places.

            Console.WriteLine("Sum = "+ sum); // Outputs the Sum 
            Console.WriteLine("Mean = "+ m); // Outputs the average


        }
    }
}

