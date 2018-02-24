
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//Write a program, which reads from the console a year and checks if it is a leap year

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok: ");
            int year;
            while(!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Invalid data! Try again: ");
            }

            if(DateTime.IsLeapYear(year))
            {
                Console.WriteLine("It is a leap year.");
            }
            else
            {
                Console.WriteLine("It is not a leap year.");
            }
        }
    }
}
