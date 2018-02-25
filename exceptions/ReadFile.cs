using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;


//Write a method that takes as a parameter the name of a text file, reads the file and returns its content as string.
//What should the method do if and exception is thrown?

namespace Program
{
    class Program
    {
        static string ReadFile(string fileName)
        {
            StringBuilder file = new StringBuilder();
            string line;

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        file.Append(line);
                    }
                }
            }
           catch(FileNotFoundException e)
            {
                Console.WriteLine("File does not exist!");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("File cannot be read!");
                Console.WriteLine(e.Message);
            }
            return file.ToString();
        }

        static void Main(string[] args)
        {
            ReadFile("Ala ma kota!");
        }
    }
}
