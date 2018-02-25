using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Net;

//Write a program that detects how many times a substring is contained in the text.
//For example, let’s look for the substring "in" in the text: 

//We are living in a yellow submarine.We don't have anything else. 
//Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days. 

//The result is 9 occurrences.

namespace Program
{ 
    class Program
    {
        static int CountPhraseOccurance(string text, string substring)
        {
            string lowText = text.ToLower();
            int count = 0;
            int index = lowText.IndexOf(substring);
            while(index != -1)
            {
                count++;
                index = lowText.IndexOf(substring, index + 1);
            }
            return count;
        }
           
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine.We don't have anything else." +
                          "Inside the submarine is very tight. So we are drinking all the day." +
                          "We will move out of it in 5 days.";
            Console.WriteLine(CountPhraseOccurance(text, "in"));

        }
    } 
}
