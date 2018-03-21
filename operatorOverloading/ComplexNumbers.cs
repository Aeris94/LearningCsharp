using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Complex
    {
        private double real;
        private double imaginery;

        public override string ToString()
        {
            return String.Format("{0} + {1}i", this.real, this.imaginery);
        }

        public Complex(double real, double imag)
        {
            this.real = real;
            this.imaginery = imag;
        }

        public Complex() : this(0, 0)
        { }

        public Complex(int real) : this(real, 0)
        { }
        
        public static Complex operator +(Complex a, Complex b)
        {
            Complex added = new Complex(a.real + b.real, a.imaginery + b.imaginery);
            return added;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(3, 4);
            Console.WriteLine("First complex number: {0}", c1);
            Complex c2 = new Complex(2, 1);
            Console.WriteLine("Second complex number: {0}", c2);

            Complex d = c1 + c2;
            Console.WriteLine("Complex number from adding first and second complex number: {0}", d);
        }
    }
}
