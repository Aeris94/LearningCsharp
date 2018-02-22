using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that by a given integer N prints the numbers from 1 to N in random order.

namespace RandomOrder
{
    class RandomOrder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            uint n;
            while(!uint.TryParse(Console.ReadLine(), out n) || n == 0)
            {
                Console.WriteLine("Invalid data! Try again: ");
            }

            int[] array = new int[n];
            for(int i = 1; i <= n; i++)
            {
                array[i - 1] = i;
            }

            Console.WriteLine("The array in order: ");
            foreach(int item in array)
            {
                Console.Write(item + " ");
            }

            Random random = new Random();
            int randomIndex;
            int temp;

            for (int i = 0; i < n; i++)
            {
                randomIndex = random.Next(0, i);

                temp = array[i];
                array[i] = array[randomIndex];
                array[randomIndex] = temp;
            }

            Console.WriteLine();
            Console.WriteLine("The array in random order: ");
            foreach(int item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
