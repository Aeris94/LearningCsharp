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

        public static bool operator true(Product p)
        {
            return (p.value != 0);
        }

        public static bool operator false(Product p)
        {
            return (p.value == 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(4);

            if (p)
                Console.WriteLine("The value of product is different from 0.");
            else
                Console.WriteLine("The value of product is zero.");
        }
    }
}
