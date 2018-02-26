using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Net;

//Define a class Student, which contains the following information about students:
//full name, course, subject, university, e-mail and phone number.

//Declare several constructors for the class Student, which have different lists
//of parameters(for complete information about a student or part of it). Data, which has 
//no initial value to be initialized with null. Use nullable types for all non-mandatory data.

//Add a static field for the class Student, which holds the number of created objects of this class.

//Add a method in the class Student, which displays complete information about the student.

//Modify the current source code of Student class so as to encapsulate the data in the class using properties.


namespace Program
{ 
    public class Student
    {
        private static int numberOfStudents = 0;
        public enum Subjects {Math, Filizophy, Biology, Histology, Programming};
        public enum Universities {PG, UG, GUMED};

        private string name;
        private string course;
        private Subjects? subject;
        private Universities? university;
        private string email;
        private string phoneNumber;

        public static int NumberOfStudents
        {
            get { return numberOfStudents; }
        }

        public Student()
        {
            this.name = null;
            this.course = null;
            this.subject = null;
            this.university = null;
            this.email = null;
            phoneNumber = null;
            numberOfStudents++;
        }

        public Student(string name, string email, string phoneNumber) : this()
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public Student(string name, string email, string phoneNumber, string course, 
                        Subjects subject, Universities university): this(name, email, phoneNumber)
        {
            this.course = course;
            this.subject = subject;
            this.university = university;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Course
        {
            get { return this.course; }
            set { this.course = value;  }
        }
        public Subjects? Subject
        {
            get { return this.subject; }
            set{ this.subject = value;}
        }
        public Universities? University
        {
            get { return this.university; }
            set { this.university = value;  }
        }
        public string Emial
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string PhoneNummber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Course: {0}", this.course);
            Console.WriteLine("Subject: {0}", this.subject);
            Console.WriteLine("University {0}", this.university);
            Console.WriteLine("Email: {0}", this.email);
            Console.WriteLine("Phone Number: {0}", this.phoneNumber);
            Console.WriteLine();
        }
    }

    //Write a class StudentTest, which has to test the functionality of the class Student.

    //  Add a static method in class StudentTest, which creates several objects of type Student 
    //and store them in static fields.Create a static property of the class to access them.
    //Write a test program, which displays the information about them in the console. 

    class StudentTest
    {
        private static Student student1;
        private static Student student2;

        public static Student Student1
        {
            get { return student1; }
        }
        public static Student Student2
        {
            get { return student2; }
        }
        
            
        public static void CreateStudents()
        {
            student1 = new Student("Jan Kowalski", "jan@gmail.com", "515339631", "Biology", Student.Subjects.Biology, Student.Universities.UG);
            student2 = new Student("Marcin Kowal", "marckow@gmail.com", "897554439");
        }
    }

    class Program
    {  
        static void Main(string[] args)
        {
            StudentTest.CreateStudents();
            Console.WriteLine("There are {0} students in database.", Student.NumberOfStudents);
            StudentTest.Student1.PrintStudentInfo();
            StudentTest.Student2.PrintStudentInfo();
        }
    } 
}
