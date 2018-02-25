using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//Write a method ReadNumber(int start, int end) that reads an integer from the console in the range[start…end]. 
//In case the input integer is not valid or it is not in the required range throw appropriate exception.Using this
//method, write a program that takes 10 integers a1, a2, …, a10 such that 1 < a1< … < a10< 100.

namespace Program
{
    class Program
    {
        static int ReadNumber(int start, int end)
        {
            int number;
            string input;
            bool isValid = true;
            Console.WriteLine("Enter a number: ");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);
            if(number < start || number >= end)
            {
                throw new OverflowException("Invalid data!");
            }
            return number;
        }

        static void Take10Numbers(int []array)
        {
            int start = 0;
            int end = 10;
            for(int i = 0; i < 10; i++)
            {
               array[i] = ReadNumber(start, end);  
               start = start + 10;
               end = end + 10;
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[10];

            try
            {
                Take10Numbers(array);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Invalid data!");
                Console.WriteLine(e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Invalid data!");
                Console.WriteLine(e.Message);
            }
            
            foreach(int value in array)
            {
                Console.Write("{0} ", value);
            }
        }
    }
}
