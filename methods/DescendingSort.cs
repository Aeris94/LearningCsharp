using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that finds the biggest element of an array.Use that method to implement sorting in descending order.

namespace Program
{
    class Program
    {
        static int FindMaxElement(int[] array, int startIndex, out int maxIndex)
        {
            int max = Int32.MinValue;
            maxIndex = 0;
            for(int i = startIndex; i < array.Length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return max;
        }

        static void SortDescending(int []array)
        {
            int temp;
            int swapIndex = 0;
            int maxValue = array[0];
            for(int i = 0; i < array.Length -1; i++)
            {
                maxValue = FindMaxElement(array, i, out swapIndex);
                temp = array[i];
                array[i] = maxValue;
                array[swapIndex] = temp;
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 3, 7, 8, 4, 10, 19, 78, 4 };
            Console.WriteLine("Before sorting: ");
            foreach(int value in array)
            {
                Console.Write("{0}  ", value);
            }
            Console.WriteLine();

            SortDescending(array);
            Console.WriteLine("After sorting: ");
            foreach(int value in array)
            {
                Console.Write("{0}  ", value);
            }
        }
    }
}
