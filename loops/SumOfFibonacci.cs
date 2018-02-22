using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console number N and print the sum of the first N members
//of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … 

namespace SumOfFibonacci
{
    class SumOfFibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Fibonacci numbers do you want to sum: ");
            uint number;
            long sum = 1;
            int firtsNum = 0;
            int secNum = 1;
            int fNum;

            while(!uint.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid data! Try again: "); 
            }

            for(int i = 0; i < number -2; i++)
            {
                fNum = firtsNum + secNum;
                firtsNum = secNum;
                secNum = fNum;

                sum += fNum;
            }

            Console.WriteLine("The sum of {0} fibonacci numbers is {1}.", number, sum);

        }
    }
}
