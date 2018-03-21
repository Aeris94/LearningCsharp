using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class TestClass
    {
        private string name;
        private int value1;
        private int value2;

        public TestClass() : this("noname", 0, 0)
        {
        }

        public TestClass(string name, int a, int b)
        {
            this.name = name;
            this.value1 = a;
            this.value2 = b;
        }

        public void Show()
        {
            Console.WriteLine("Name: {0} Value1: {1}, Value2: {2}", this.name, this.value1, this.value2);
        }

        //overloading + operator
        public static TestClass operator +(TestClass a, TestClass b)
        {
            TestClass c = new TestClass(String.Format("{0} + {1}", a.name, b.name), (a.value1 + b.value1), (a.value2 + b.value2));
            return c;
        }

        //adding constatnt to the class
        public static TestClass operator +(TestClass c, int num)
        {
            TestClass d = new TestClass(String.Format("{0} + {1}", c.name, num), c.value1 + num, c.value2 + num);
            return d;
        }

        public static TestClass operator +(int num, TestClass c) 
        {
            TestClass d = new TestClass(String.Format("{0} + {1}", c.name, num), c.value1 + num, c.value2 + num);
            return d;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestClass a = new TestClass("a", 3, 4);
            a.Show();
            TestClass b = new TestClass("b",4, 5);
            b.Show();

            TestClass c = a + b;
            c.Show();
            TestClass d = c + 5;
            d.Show();
            c.Show();
        }
    }
}
