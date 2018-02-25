using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;

//Write a program that gets from the user the full path to a file(for example C:\Windows\win.ini),
//reads the content of the file and prints it to the console.Find in MSDN how to us the System.IO.File.ReadAllText(…) 
//method.Make sure all possible exceptions will be caught and a user-friendly message will be printed on the console.

namespace Program
{
    class Program
    {
        static void ReadAllText(string filePath)
        {
            if (File.Exists(filePath))
            {
                string readText;
                try
                {
                    readText = File.ReadAllText(filePath);
                    Console.WriteLine(readText);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong.");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("File not found or path name is invalid.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a path to a file you want to read: ");
            string path = Console.ReadLine();
            ReadAllText(path);
        }
    } 
}
