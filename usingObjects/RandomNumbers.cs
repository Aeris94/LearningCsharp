using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//Write a program, which generates and prints on the console 10 random numbers in the range[100, 200].

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = 0;
            for(int i = 0; i <10; i++)
            {
                number = random.Next(100, 201);
                Console.WriteLine("Random number {0}: {1}", i + 1, number);
            }
        }
    }
}
