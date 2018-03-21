using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Product
    {
        private int value;

        public Product(int value)
        {
            this.value = value;
        }

        public Product() : this(0)
        { }

        public override string ToString()
        {
            return String.Format("{0}", value);
        }

        public static bool operator <(Product p1, Product p2)
        {
            if (p1.value < p2.value)
                return true;
            else return false;
        }

        public static bool operator >(Product p1, Product p2)
        {
            if (p1.value > p2.value)
                return true;
            else return false;
        }

        public static bool operator == (Product p1, Product p2)
        {
            if (p1.value == p2.value)
                return true;
            else return false;
        }

        public static bool operator != (Product p1, Product p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            if(obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            return this == (Product)obj;
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(5);
            Product p2 = new Product(3);

            Console.WriteLine("p1 is smaller than p2: {0}", p1 < p2);
            Console.WriteLine("p1 is bigger than p2: {0}", p1 > p2);

            Console.WriteLine("p1 is equal to p2: {0}", p1 == p2);
            Console.WriteLine("p1 is equal to p2 with Equals method: {0}", p1.Equals(p2));
        }
    }
}
