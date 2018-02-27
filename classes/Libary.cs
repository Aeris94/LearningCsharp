using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Net;

//There is a book library.Define classes respectively for a book and a library.
//The library must contain a name and a list of books.The books must contain the title, 
//author, publisher, release date and ISBN-number.In the class, which describes the library, 
//create methods to add a book to the library, to search for a book by a predefined author, 
//to display information about a book and to delete a book from the library.


namespace Program
{ 
    public class Book
    {
        private string title;
        private string author;
        private string publisher;
        private DateTime relseDate;
        private string isbn;

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public string Publisher
        {
            get { return this.publisher; }
            set { this.publisher = value; }
        }
        public DateTime RelseDate
        {
            get { return this.relseDate; }
            set { this.relseDate = value; }
        }
        public string ISBN
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }

        public Book(string title,string author, string publisher, DateTime relseDate, string isbn)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.relseDate = relseDate;
            this.isbn = isbn;
        }

        public override string ToString()
        {
            string bookInfo = $"Title: {this.title} \nAuthor: {this.author} \nPublisher: {this.publisher}"
                + $"\nRelse Date: {this.relseDate} \nISBN Number: {this.isbn}";
            return bookInfo;
        }
    }

    public class Libary
    {
        private List<Book> libaryCollection;
        
        public List<Book> LibaryCollection
        {
            get { return libaryCollection; }
        }

        public Libary()
        {
            libaryCollection = new List<Book>();
        }

        public void AddBook(string title, string author, string publisher, DateTime relseDate, string isbn)
        {
            libaryCollection.Add(new Book(title, author, publisher, relseDate, isbn));
        }

        public void AddBook()
        {
            string title;
            string author;
            string publisher;
            DateTime relseDate;
            string isbn;
            Book book;

            Console.WriteLine("Enter a title: ");
            title = Console.ReadLine();
            Console.WriteLine("Enter an author: ");
            author = Console.ReadLine();
            Console.WriteLine("Enter a publisher: ");
            publisher = Console.ReadLine();
            Console.WriteLine("Enter isbn: ");
            isbn = Console.ReadLine();
            Console.WriteLine("Enter a relse date: ");
            if(!DateTime.TryParse(Console.ReadLine(), out relseDate))
            {
                throw new InvalidCastException("Date format is invalid.");
            }

            book = new Book(title, author, publisher, relseDate, isbn);
            libaryCollection.Add(book);
        }

        public void DeleteBook(string isbn)
        {
            int index;
            if ((index = libaryCollection.FindIndex(x => x.ISBN.Equals(isbn))) >= 0)
            {
                libaryCollection.RemoveAt(index);
            }
            else 
            {
                throw new ArgumentException("Book witch given ISBN does not exist in libaty collection.");
            }
        }

        public string SearchByAuthor(string author)
        {
            if (libaryCollection.Exists(x => x.Author.Equals(author)))
            {
                return libaryCollection.Find(x => x.Author.Equals(author)).ToString();
            }
            else
            {
                throw new ArgumentException("Book with given author does not exist.");
            }
        }

        public void showLibaryCollection()
        {
            foreach (Book book in libaryCollection)
            {
                Console.WriteLine(book.ToString());
                Console.WriteLine();
            }
        }
    }
    
    class Program
    {  
        static void Main(string[] args)
        {
            Libary libary = new Libary();
            libary.AddBook("Maistrz i Małgorzata", "Bułhakov", "PWN", new DateTime(1998, 02, 01), "DS-980-7878");
            libary.showLibaryCollection();
            Console.WriteLine(libary.SearchByAuthor("Bułhakov"));
            libary.showLibaryCollection();
        }
    } 
}
