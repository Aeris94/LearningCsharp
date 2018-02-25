using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;

//Search for information in Internet and define your own class for exception FileParseException.
//The exception has to contain the name of the processed file and the number of the row where the problem 
//is occurred.Add appropriate constructors in the exception. Write a program that reads integers from a text file.
//If the during reading a row does not contain an integer throw FileParseException and pass it to the calling method.

namespace Program
{
    class FileParseException : ApplicationException
    {
        private string fileName;
        private int line;

        public string FileName
        {
            get { return this.fileName; }
        }

        public int Line
        {
            get { return this.line; }
        }

        public FileParseException()
        {
        }

        public FileParseException(string message, string fileName, int line) : base(message)
        {
            this.fileName = fileName;
            this.line = line;
        }

        public FileParseException(string message, string fileName, int line, Exception inner) : base(message, inner)
        {
            this.fileName = fileName;
            this.line = line;
        }
    }

    class Program
    {
        static void ReadNumbers(string fileName)
        {
            if(File.Exists(fileName))
            {
                int line = 0;
                int number;
                string stringNumber;
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while((stringNumber = reader.ReadLine()) != null)
                    {
                        line++;
                        if(int.TryParse(stringNumber, out number))
                        {
                            Console.WriteLine(number);
                        }
                        else
                        {
                            throw new FileParseException("Problem occured. The line does not contain integer or there are" +
                                "two or more numbers in the row.", fileName, line);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Numbers in the file: ");
            try
            {
                ReadNumbers("numbers.txt");
            }
            catch(FileParseException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("File name: {0} \nLine: {1}", e.FileName, e.Line);
            }
        }
    } 
}
