using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that finds how many times certain number can be found in a given array.


namespace Program
{
    class Program
    {
        static int CountOccurances(int []array, int number)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(number == array[i])
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 3, 4, 5, 5, 5 };
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("The number {0} is found in the array {1} times.", a, CountOccurances(array, a));
       
        }
    }
}
