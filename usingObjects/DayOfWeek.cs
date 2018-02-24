using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//Write a program, which prints, on the console which day of the week is today.

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = new DateTime();
            today = DateTime.Now;
            Console.WriteLine("Today is {0}", today.DayOfWeek);
        }
    }
}
