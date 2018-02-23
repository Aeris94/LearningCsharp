using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the English name of the last digit of a given number.Example: 
//for 512 prints "two"; for 1024  "four"


namespace Program
{
    class Program
    {
        static string LastDigit(int number)
        {
            int lastDigit = (number % 10);
            switch(lastDigit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }
            return "";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Last digit of the number is: {0}.", LastDigit(number));
       
        }
    }
}
