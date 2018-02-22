using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sorting an array means to arrange its elements in an increasing(or decreasing) order.
//Write a program, which sorts an array using the algorithm "selection sort".

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 5, 9, 7, 3, 11, 3, 6, 19 };

            int min;
            int temp;

            Console.WriteLine("Array before sorting: ");
            foreach(int value in array)
            {
                Console.Write("{0}, ", value);
            }

           
            for (int i = 0; i < array.Length -1; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                if(min != i)
                {
                    temp = array[i];
                    array[i] = min;
                    array[min] = temp;
                }
            }

            Console.WriteLine("Array after sorting: ");
            foreach(int value in array)
            {
                Console.Write("{0}, ", value);
            }
        }
    }
}
