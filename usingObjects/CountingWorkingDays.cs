using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//Write a program, which calculates the count of workdays between the current date and another given date after 
//the current(inclusive). Consider that workdays are all days from Monday to Friday, which are not public holidays,
//except when Saturday is a working day.The program should keep a list of predefined public holidays,
//as well as a list of predefined working Saturdays.


namespace Program
{
    static class WrokingDays
    {
        static private DateTime[] hollydays = new DateTime[] { new DateTime(2018, 01, 01), new DateTime(2018, 01, 06),
                                                new DateTime(2018, 04, 01), new DateTime(2018, 04, 02),
                                                new DateTime(2018, 05, 01), new DateTime(2018, 05, 03),
                                                new DateTime(2018, 05, 20), new DateTime(2018, 05, 31),
                                                new DateTime(2018, 11, 01), new DateTime(2018, 11, 11),
                                                new DateTime(2018, 12, 25), new DateTime(2018, 12, 26)};

        static public int CountWorkingDays(DateTime d)
        {
            int workingDays = 0;
            DateTime data = new DateTime();
            data = DateTime.Now;
            string day;

            while(DateTime.Compare(data, d) <0)
            {
                day = data.DayOfWeek.ToString();
                if(day != "Saturday" && day != "Sunday")
                {
                    workingDays++;
                }

                for(int i =0; i< hollydays.Length; i++)
                {
                    if(DateTime.Compare(data, hollydays[i]) == 0)
                    {
                        workingDays--;
                    }
                }
                data = data.AddDays(1);
            }
            return (workingDays);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2018, 04, 01);
            Console.WriteLine(WrokingDays.CountWorkingDays(date));  
        }
    }
}
