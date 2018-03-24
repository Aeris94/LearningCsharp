using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public delegate void Calculate(int a, int b);
    public delegate void EventHandler();
    public delegate void ProductDel();

    class Program
    {
        public static event Calculate EventToCalculate;
        public static event EventHandler MultipleEvents;
        

        public static void RectArea(int a, int b)
        {
            Console.WriteLine("The rectangle area: {0}", a * b);
        }

        class Product
        {
            public event ProductDel ProductEvent;
            int value;

            public int Value
            {
                get
                {
                    return this.value;
                }
                set
                {
                    this.value = value;
                    ProductEvent += new ProductDel(this.Display);
                    RaiseEvent();
                }
            }

            public Product(int x)
            {
                this.value = x;
            }

            public void RaiseEvent()
            {
                ProductEvent.Invoke();
            }

            public void Display()
            {
                Console.WriteLine("Event has been fired: the product value is now {0}", this.value);
            }
        }

        static void Main(string[] args)
        {
            EventToCalculate += new Calculate(RectArea);
            EventToCalculate(3, 4);

            MultipleEvents += new EventHandler(hendler1);
            MultipleEvents += new EventHandler(handler2);
            MultipleEvents += new EventHandler(handler3);
            MultipleEvents();


            Product p = new Product(5);
            p.Value = 10;            

        }

        public static void hendler1()
        {
            Console.WriteLine("Handler 1.");
        }
        public static void handler2()
        {
            Console.WriteLine("Handler 2.");
        }
        public static void handler3()
        {
            Console.WriteLine("Handler 3.");
        }
    }
}
