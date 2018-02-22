using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program, which finds the maximal sequence of consecutive equal elements 
//in an array.E.g.: { 1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1, 2, 3, 2, 2, 2, 1};
            int maxStart = 0;
            int maxLen = 0;
            int len = 1;
            int start = 0;

            for(int i = 0; i < array.Length - 1; i++)
            {
                if(array[i] != array[i+1])
                {
                    start = i + 1;
                    len = 1;
                }
                else
                {
                    len++;
                }

                if(len > maxLen)
                {
                    maxLen = len;
                    maxStart = start;
                }
            }

            Console.WriteLine("The maximal sequence of equal elements in array is: ");
            Console.Write("{");
            for (int i = maxStart; i < maxStart + maxLen; i++)
            {
                Console.Write(" {0} ", array[i]);
            }
            Console.Write("}");
        }
    }
}
