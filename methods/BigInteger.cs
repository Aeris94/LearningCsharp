using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//Write a program that calculates and prints the n! for any n in the range[1…100]. 
namespace Program
{
    class Program
    { 
        static BigInteger Factorial(int n)
        {
            BigInteger factorial = new BigInteger(1);
            for(int i= n; i>=1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 1 to 100: ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n) || ((n<1) || (n>100)))
            {
                Console.WriteLine("Invalid data! Try again: ");
            }
            Console.WriteLine(Factorial(n));
        }
    }
}
