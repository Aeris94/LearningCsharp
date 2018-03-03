using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement the following classes: Dog, Frog, Cat, Kitten and Tomcat.All of them are animals(Animal).
//Animals are characterized by age, name and gender.Each animal makes a sound(use a virtual method in the Animal class).
//Create an array of different animals and print on the console their name, age and the corresponding sound 
//each one makes.

namespace Inheritance
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] array = new Animal[5];
            array[0] = new Dog("Oreo", 3, true);
            array[1] = new Cat("Fibi", false);
            array[2] = new Frog("Frodo", 2, true);
            array[3] = new Kitten("Malwina", 1, false);
            array[4] = new Tomcat("Tom", true);


            foreach(Animal a in array)
            {
                Console.WriteLine(a);
                Console.WriteLine();
            }
        }
    }
}
