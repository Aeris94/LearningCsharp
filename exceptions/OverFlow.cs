using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//Write a program that takes a positive integer from the console and prints the square root of this integer.
//If the input is negative or invalid print "Invalid Number" in the console. In all cases print "Good Bye"


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = 0;
            string input;
            Console.WriteLine("Enter a number: ");
            input = Console.ReadLine();

            try
            {
                number = Convert.ToUInt32(input);
                Console.WriteLine("The squre root of {0} is {1}.", number, Math.Sqrt(number));
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid data!");
            }          
            catch (FormatException)
            {
                 Console.WriteLine("Invalid data!");
            }
            finally
            {
                Console.WriteLine("Good Bye!");
            }
        }
    }
}
