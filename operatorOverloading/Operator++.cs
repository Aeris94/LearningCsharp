using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Product
    {
        int price;
        int quantity;

        public Product(int p, int q)
        {
            this.price = p;
            this.quantity = q;
        }

        public Product() : this(0, 0)
        { }

        public override string ToString()
        {
            return String.Format("Price: {0} Quantity: {1}", this.price, this.quantity);
        }

        public static Product operator ++(Product p)
        {
            p.quantity += 1;
            p.price += 1;
            return p;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(3, 4);
            Console.WriteLine("Product 1: {0}", p);
            Product f = p;
            Console.WriteLine("Product 2: {0}", f);
            p++;
            Console.WriteLine("After incrementation Product 1: {0}", p);
            Console.WriteLine("After incrementation Product 2: {0}", f);
        }
    }
}
