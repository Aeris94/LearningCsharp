using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//You are given a sequence of positive integer numbers given as string of numbers separated by a space.
//Write a program, which calculates their sum.Example: "43 68 9 23 318"  461. 


namespace Program
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separeted by a space.");
            string stringOfNumbers = Console.ReadLine();

            string[] array = stringOfNumbers.Split(' ');
            List<int> numbers = new List<int>();

            int number;
            for(int i = 0; i< array.Length; i++)
            {
                if(int.TryParse(array[i], out number))
                {
                    numbers.Add(number);
                }
            }

            int sum = numbers.Sum();
            Console.WriteLine("The sum of numbers is {0}", sum);
            
        }
    }
}
