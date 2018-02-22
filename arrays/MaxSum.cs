using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program, which reads from the console two integer numbers N and K(K<N) and array of N integers.
//Find those K consecutive elements in the array, which have maximal sum.

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to enter: ");
            uint n;
            while(!uint.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Invalid data! Try again: ");
            }

            int[] array = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a number: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Invalid data! Try again: ");
                }
            }

            Console.WriteLine("Program will find maximal sum of K elements in the array. Enter K: ");
            uint k;
            while(!uint.TryParse(Console.ReadLine(), out k) || k > n)
            {
                Console.WriteLine("Invalid data! Try again: ");
            }

            int sum = 0;
            int maxSum = 0;
            int start = 0;
            int maxStart = 0;

            for(int i = 0; i < array.Length - k + 1; i++)
            {
                sum = 0;
                start = i;
                for(int m = 0; m < k; m++)
                {
                    sum += array[m + i];
                }

                if(sum > maxSum)
                {
                    maxSum = sum;
                    maxStart = start;
                }
            }

            Console.WriteLine("The maximal sum in the array is {0}", maxSum);
            Console.Write("The best elements of the array are: ");
            for(int i = maxStart; i < maxStart + k; i++)
            {
                Console.Write("{0},  ", array[i]);
            }
        }
    }
}
