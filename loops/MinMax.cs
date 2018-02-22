using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a series of integers and prints the smallest and largest of them.

namespace Loops
{
    class MinMax
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you wisch to eneter?");
            uint num;
            while(!uint.TryParse(Console.ReadLine(), out num) || num == 0)
            {
                Console.WriteLine("Invalid data. Try again: ");
            }

            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            int val;

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Eneter a number: ");
                while (!int.TryParse(Console.ReadLine(), out val))
                {
                    Console.WriteLine("Invalid data! Try again: ");
                }
                if(min > val)
                {
                    min = val;
                }
                if(max < val)
                {
                    max = val;
                }
            }
            Console.WriteLine("The samllest number is {0} and the largest number is {1}", min, max);
        }
    }

}
