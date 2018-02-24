using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


//Write a program which creates 10 objects of type Cat, gives them names CatN, where N is a unique serial
//number of the object, and in the end call the method SayMiau() for each of them.For the implementation 
//use the namespace CreatingAndUsingObjects.

namespace CreatingAndUsingObjects
{
    class Cat
    {
        static int serialNumber = 0;
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Cat()
        {
            serialNumber++;
            name = "Cat " + serialNumber;
        }

        public void SayMiau()
        {
            Console.WriteLine("{0} says miauuuu.", this.name);
        }
    }
}

namespace Program
{
    using CreatingAndUsingObjects;
    class Program
    {
        static void Main(string[] args)
        {
            Cat[] catArray = new Cat[10];
            for(int i =0; i < 10; i++)
            {
                catArray[i] = new Cat();
                catArray[i].SayMiau();
            }
                       
            
        }
    }
}
