using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that calculates N!/K! for given N and K(1<K<N). 
//Write a program that calculates N!* K!/(N-K)! for given N and K(1<K<N).

namespace N_K_
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
            uint n;
            uint k;

            Console.WriteLine("Program will calculate N!/K! and N!*K!/(N-K)! (1 < K < N ).");
            Console.WriteLine("Enter K: ");
            while(!uint.TryParse(Console.ReadLine(), out k) || k <= 1)
            {
                Console.WriteLine("Invalid data! Try again: ");
            }

            Console.WriteLine("Enter N: ");
            while(!uint.TryParse(Console.ReadLine(), out n) || n <= k)
            {
                Console.WriteLine("Invalid data! Try again: ");
            }

            Console.WriteLine("N!/K! = {0}", factorial(n) / factorial(k));
            Console.WriteLine("N!*K!/(N-K)! = {0}", factorial(n) * factorial(k) / (factorial(n - k)));
        }
    }
}
