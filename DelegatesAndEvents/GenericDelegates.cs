using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public delegate T2 Calc<T1, T2>(T1 a, T1 b);

    class Program
    {
        public static int RectArea(int a, int b)
        {
            return a * b;
        }

        public static double TriangleArea(int a, int b)
        {
            return (0.5*a*b);
        }

        static void Main(string[] args)
        {
            Calc<int, int> rect = new Calc<int, int>(RectArea);
            Console.WriteLine("The area of the rectangle: {0}.", rect(2, 3));

            Calc<int, double> triangle = new Calc<int, double>(TriangleArea);
            Console.WriteLine("The area of the triangle: {0}.", triangle(2, 3));
        }
    }
}
