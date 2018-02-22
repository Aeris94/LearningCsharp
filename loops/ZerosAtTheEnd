using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that calculates with how many zeroes the factorial of a given number 
//ends.Examples: N = 10->N! = 3628800 -> 2 

namespace ZerosAtEnd
{
    class Program
    {
        static long factorial(uint n)
        {
            long factorial = 1;
            for (uint i = n; i > 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }

        static void Main(string[] args)
        {
            uint number;
            Console.WriteLine("Enetr a number: ");
            while(!uint.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid data! Try again: ");
            }

            long fac = factorial(number);
            long fact = fac;
            int zeros = 0;

            while(fact%10 == 0)
            {
                zeros++;
                fact = fact / 10;
            }

            Console.WriteLine("The factorial of {0} is {1} and has {2} zeros at the end.", number, fac, zeros);   
        }
    }
}
