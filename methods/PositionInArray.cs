using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the position of the first occurrence of an element from an array, 
//such that it is greater than its two neighbors simultaneously.Otherwise the result must be -1. 

namespace Program
{
    class Program
    {
        static bool IsGreaterThanNeighbors(int []array, uint index)
        {
            if(index > 0 && index < array.Length -1)
            {
                if((array[index] > array[index-1]) && array[index] > array[index +1])
                {
                    return true;
                }
            }
            else if(index == 0)
            {
                if(array[index] > array[index + 1])
                {
                    return true;
                }
            }
            else
            {
                if(array[index] > array[index -1])
                {
                    return true;
                }
            }
            return false;
        }

        static int Position(int []array, int number)
        {
            for(int i = 0; i< array.Length; i++)
            {
                if(number == array[i])
                {
                    if(IsGreaterThanNeighbors(array, (uint)i))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 2, 1, 2, 3, 4, 4, 7 };
           

            foreach (int value in array)
            {
                Console.Write("{0}, ", value);
            }
            int number = 0;
            Console.WriteLine("Enter a number: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid data! Try again: ");
            }

            Console.WriteLine("First occurance of number {0} that is greather than its neightbours is at index: {1}", number, Position(array, number));

          
        
        }
    }
}
