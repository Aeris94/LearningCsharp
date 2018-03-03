using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Circle : Shape
    {
        public Circle(double radius) : base(radius, radius)
        { }

        public override double CalculateSurface()
        {
            return this.Width * this.Height * Math.PI;
        }
    }
}
