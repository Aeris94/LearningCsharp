using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints all possible cards from a standard deck of cards,
//without jokers(there are 52 cards: 4 suits of 13 cards) using loops and switch statements. 

namespace ConsoleApp1
{
    class DeckOfCards
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The deck of cards(wihout jokers: ");
            for(int i = 1; i <=4; i++)
            {
                for(int j = 1; j <=13; j++)
                {
                    if (j <= 10)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        switch (j)
                        {
                            case 11: Console.Write("J"); break;
                            case 12: Console.Write("Q"); break;
                            case 13: Console.Write("K"); break;
                            case 14: Console.Write("A"); break;
                        }
                    }
                    switch(i)
                    {
                        case 1: Console.WriteLine(" club"); break;
                        case 2: Console.WriteLine(" dimond"); break;
                        case 3: Console.WriteLine(" heart"); break;
                        case 4: Console.WriteLine(" spades"); break;
                    }
                }
            }

        }
    }
}
