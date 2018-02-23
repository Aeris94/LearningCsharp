using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that checks whether an element, from a certain position in an array is greater than its two neighbors.
//Test whether the method works correctly


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

        static void Main(string[] args)
        {
            int[] array = new int[] { 7, 2, 1, 2, 3, 4, 4, 7 };
            Console.WriteLine("Enter an index: ");
            uint index = 0;
            while(!uint.TryParse(Console.ReadLine(), out index) || index >= array.Length)
            {
                Console.WriteLine("Invalid data! Try again: ");
            }
            foreach(int value in array)
            {
                Console.Write("{0}, ", value);
            }

            string greater = IsGreaterThanNeighbors(array, index)? "is greater": "is not greater";
            Console.WriteLine();
            Console.WriteLine("The number at index {0} {1} than its neightbours.", index, greater);
        }
    }
}
