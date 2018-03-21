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

        public static implicit operator int(Product p)
        {
            int n = p.value;
            return n;
        }

        public static explicit operator Product(int num)
        {
            Product n = new Product(num);
            return n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(5);

            int n = p1;
            Console.WriteLine(n);
            int z = 8;
            Product p2 = (Product)z;
            Console.WriteLine(p2);
        }
    }
}
