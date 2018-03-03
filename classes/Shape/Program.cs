using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define an abstract class Shape with abstract method CalculateSurface() and fields width and height.
//Define two additional classes for a triangle and a rectangle, which implement CalculateSurface(). 
//This method has to return the areas of the rectangle(height* width) and the triangle(height* width/2). 
//Define a class for a circle with an appropriate constructor, which initializes the two fields(height and width)
//with the same value(the radius) and implement the abstract method for calculating the area.Create an array
//of different shapes and calculate the area of each shape in another array.

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] array = new Shape[3];
            array[0] = new Rectangle(2, 2);
            array[1] = new Triangle(4, 3);
            array[2] = new Circle(2);

            foreach(Shape s in array)
            {
                Console.WriteLine("The surface area of {0} is {1}", s.ToString().Substring(9), s.CalculateSurface());
            }
        }
    }
}
