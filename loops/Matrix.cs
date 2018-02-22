using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a positive integer number N(N< 20) and prints
//a matrix of numbers as on the figures below:        N = 3    
//    1 2 3
//    2 3 4
//    3 4 5 
 
namespace Matrix
{
    class Matrix
    {
        static void Main(string[] args)
        {
            uint number;
            Console.WriteLine("Enter a number: ");
            while(!uint.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid data! Try again: ");
            }

            uint start = 1;
            for(int i = 1; i <=number; i++)
            {
                for(uint j = start; j < start + number; j++)
                {
                    Console.Write("{0, 4}", j);
                }
                start++;
                Console.WriteLine();
            }
        }
    }
}
