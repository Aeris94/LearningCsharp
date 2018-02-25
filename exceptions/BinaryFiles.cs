using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;


//Write a method that takes as a parameter the name of a binary file, reads the content of the file and returns
//it as an array of bytes.Write a method that writes the file content to another file. Compare both files

namespace Program
{
    class Program
    {
        static List<byte> BinaryFileToArray(string fileName)
        {
            List<byte> list = new List<byte>();
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        list.Add(reader.ReadByte());
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File does not exist.");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("File cannot be read.");
                Console.WriteLine(e.Message);
            }
            return list;
        }


        static void CopyBinaryFile(string fileName1, string fileName2)
        {
            if(File.Exists(fileName1))
            {
                BinaryReader reader = null;
                BinaryWriter writer = null;
                try
                {
                    reader = new BinaryReader(File.Open(fileName1, FileMode.Open));
                    writer = new BinaryWriter(File.Open(fileName2, FileMode.Create));
                    while(reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        writer.Write(reader.ReadByte());
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Something went wrong!");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    reader.Dispose();
                    writer.Dispose();
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }


        static void Main(string[] args)
        {
      
        }
    } 
}
