using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In combinatorics, the Catalan numbers are calculated by the following
//formula: Cn = (2n)!/((n+1)!*n!) for n ≥ 0. Write a program that calculates the nth Catalan number by given n.

namespace CatalanNumbers
{
    class CatalanNumbers
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
            Console.WriteLine("Enter the Catalan number you want to calculate: ");
            uint n;

            while(!uint.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Invalid data! Try again:");
            }

            Console.WriteLine("The {0}nt Catalan number is {1}", n, factorial(2 * n) / (factorial(n + 1) * factorial(n)));
        }
    }
}
