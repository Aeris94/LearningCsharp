using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//Write a program, which generates a random advertising message for some product.The message has to consist of
//laudatory phrase, followed by a laudatory story, followed by author (first and last name) and city,
//which are selected from predefined lists.
//For example, let’s have the following lists: 
//- Laudatory phrases: {"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category."}. 
//- Laudatory stories: {"Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."}.
//- First name of the author: {"Dayan", "Stella", "Hellen", "Kate"}. 
//- Last name of the author: {"Johnson", "Peterson", "Charls"}. 
//- Cities: {"London", "Paris", "Berlin", "New York", "Madrid"}. 
//Then the program would print randomly generated advertising message.


namespace Program
{
    class AdvertMessage
    {
        static private string[] phrases = { "The product is excellent. ", "This is a great product. ", "I use this product constantly. ", "This is the best product from this category. " };
        static private string[] stories = { "Now I feel better. ", "I managed to change. ", "It made some miracle. ", "I can’t believe it, but now I am feeling great. ", "You should try it, too. I am very satisfied. " };
        static private string[] names = { "Dayan ", "Stella ", "Hellen ", "Kate " };
        static private string[] surnames = { "Johnson", "Peterson", "Charls" };
        static private string[] cities = { "London ", "Paris ", "Berlin ", "New York ", "Madrid " };
        private StringBuilder message = new StringBuilder();

        public AdvertMessage()
        {
            GenerateMessage();
        }

        private int GenerateIndex(string []array)
        {
            Random random = new Random();
            int index = random.Next(0, array.Length);
            return index;
        }

        private void AppendMessage(string []array)
        {
            int index = GenerateIndex(array);
            message.Append(array[index]);
        }

        private void GenerateMessage()
        {
            AppendMessage(phrases);
            AppendMessage(stories);
            message.Append(" -- ");
            AppendMessage(names);
            AppendMessage(surnames);
            message.Append(", ");
            AppendMessage(cities);
        }

        public void ShowMessage()
        {
            Console.WriteLine(this.message);
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            AdvertMessage message1 = new AdvertMessage();
            message1.ShowMessage();
        }
    }
}
