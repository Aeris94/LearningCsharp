using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program, which finds the maximal sequence of consecutively placed increasing 
//integers.Example: { 3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}. 

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 2, 3, 4, 2, 2, 4, 10, 6, 7, 8, 9};
            int maxStart = 0;
            int maxLen = 0;
            int len = 1;
            int start = 0;

            for(int i = 0; i < array.Length - 1; i++)
            {
                if(array[i+1] < array[i] + 1)
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

            Console.WriteLine("The maximal sequence of incresing elements in array is: ");
            Console.Write("{");
            for (int i = maxStart; i < maxStart + maxLen; i++)
            {
                Console.Write(" {0} ", array[i]);
            }
            Console.Write("}");
        }
    }
}
