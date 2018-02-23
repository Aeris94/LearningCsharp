using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that calculates the sum of two very long positive integer numbers.
//The numbers are represented as array digits and the last digit (the ones) is stored in the array at index 0.
//Make the method work for all numbers with length up to 10,000 digits

namespace Program
{
    class Program
    {
        static int[] AddLongNumbers(int []firstNumber, int []secondNumber)
        {
            int len = firstNumber.Length > secondNumber.Length ? firstNumber.Length : secondNumber.Length;
            int[] number = new int[len+1];
            number[0] = (firstNumber[0] + secondNumber[0]) % 10;
            for (int i = 1; i < len; i++)
            {
                number[i] = (firstNumber[i] + secondNumber[i]) % 10 + (firstNumber[i-1] + secondNumber[i-1]) / 10;
            }
            number[len] = (firstNumber[len - 1] + secondNumber[len - 1]) / 10;
            return number;
        }
        
        static void Main(string[] args)
        {
            int[] firstNumber = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] secondNumber = new int[] { 1, 1, 1, 8, 9, 0, 9 };
            int len = firstNumber.Length > secondNumber.Length ? firstNumber.Length : secondNumber.Length;
            int[] result = new int[len+1];
            result = AddLongNumbers(firstNumber, secondNumber);
            
            for(int i = len; i>=0; i--)
            {
                Console.Write("{0}", result[i]);
            }
            Console.WriteLine();
        }
    }
}
