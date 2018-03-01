using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class Human with properties "first name" and "last name". Define the class Student inheriting Human, 
//which has the property "mark". Define the class Worker inheriting Human with the property "wage" and "hours worked". 
//Implement a "calculate hourly wage" method, which calculates a worker’s hourly pay rate based on wage and hours
//worked.Write the corresponding constructors and encapsulate all data in properties.

//Initialize an array of 10 students and sort them by mark in ascending order. Use the interface System.IComparable<T>.

//Initialize an array of 10 workers and sort them by salary in descending order

namespace Inheritance
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = new Student[10];
            studentArray[0] = new Student("Ada", "Wronoska", 3);
            studentArray[1] = new Student("Jan", "Kowal", 7);
            studentArray[2] = new Student("Marta", "Gf", 4);

            foreach(Student s in studentArray)
            {
                Console.WriteLine(s);
            }

            Human<Student>.SortDesc(studentArray);
            foreach(Student s in studentArray)
            {
                Console.WriteLine(s);
            }
        }
    }
}
