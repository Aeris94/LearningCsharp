using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that prints the digits of a given decimal number in a reversed order.For example 256,
//must be printed as 652. 

namespace Program
{
    class Program
    {
        static int ReversedInt(int number)
        {
            int digit;
            StringBuilder reversedNumber = new StringBuilder("");

            if (number == 0)
                return 0;
            while (number != 0)
            {
                digit = number % 10;
                reversedNumber.Append((digit.ToString()));
                number /= 10;
            }
            return (Convert.ToInt32(reversedNumber.ToString()));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number reversed: {0}", ReversedInt(number));
        
        }
    }
}
