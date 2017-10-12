using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingGetHashCode__
{
    class Point3D : IEqualityComparer<Point3D>
    {
        private double X { get; }
        private double Y { get; }
        private double Z { get; }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return $"({this.X}, {this.Y}, {this.Z})";
        }

        public bool Equals(Point3D point1, Point3D point2)
        {
            if(point1 == point2)
                return true;

            if (point1 == null || point2 == null)
                return false;

            if (!point1.X.Equals(point2.X))
                return false;
           
            if (!point1.Y.Equals(point2.Y))
                return false;
           
            if (!point1.Z.Equals(point2.Z))
                return false;

            return true;
        }

        public int GetHashCode(Point3D point)
        {
            if(point == null)
            {
                return 0;
            }
            int primeNumber = 83;
            int result = 1;
            result = result * primeNumber + point.X.GetHashCode();
            result = result * primeNumber + point.Y.GetHashCode();
            result = result * primeNumber + point.Z.GetHashCode();

            return result;
        }
    }
}
