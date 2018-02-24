using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//Write a program, which prints on the standard output the count of days, hours, and minutes,
//which have passes since the computer is started until the moment of the program execution.
//For the implementation use the class Environment

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            long count = (Environment.TickCount)/1000;

            int seconds = (int)count%60;
            int minutes = (int)((count / 60) % 60);
            int hours = (int)(count / 3600);
            
            Console.WriteLine("The computer started {0} hours, {1} minutes and {2} seconds ago.", hours, minutes, seconds);
        }
    }
}
