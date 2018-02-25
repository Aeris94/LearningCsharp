using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Net;

//Write a program that reads a string, reverse it and prints it to the console.
//For example: "introduction" -> "noitcudortni".

namespace Program
{ 
    class Program
    {
        static string ReverseString(string text)
        {
            StringBuilder reversedText = new StringBuilder();
            for (int i = text.Length-1; i >= 0; i--)
            {
                reversedText.Append(text[i]);
            }
            return reversedText.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Type a text you want to reverse: ");
            string text = Console.ReadLine();
            string reversed = ReverseString(text);
            Console.WriteLine(reversed);
        }
    } 
}
