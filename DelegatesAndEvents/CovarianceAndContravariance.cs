using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    delegate int FunDelegate(int a, int b);

    class RectArea
    {
        protected int a;
        protected int b;

        public RectArea(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public RectArea ReturnRectArea()
        {
            Console.WriteLine("Returning RectArea object.");
            return this;
        }

        public double GetRect()
        {
            return this.a * this.b;
        }
    }

    class TriangleArea : RectArea
    {
        public TriangleArea(int a, int b) : base(a, b)
        {
        }

        public TriangleArea returnTraingleArea()
        {
            Console.WriteLine("Returning TriangleArea object.");
            return this;
        }

        public double GetTriangle()
        {
            return (0.5 * this.a * this.b);
        }
    }


    class Program
    {
        public delegate RectArea CovDelg();
        public delegate void ContDeleg(TriangleArea tr);

        private static void PassRectArea(RectArea r)
        {
            Console.WriteLine("Passing RectArea object: {0}.", r.GetRect());
        }

        private static void PassTriangleArea(TriangleArea t)
        {
            Console.WriteLine("Passing TriangleArea object: {0}.", t.GetTriangle());
        }

        static void Main(string[] args)
        {
            RectArea r = new RectArea(2, 3);
            TriangleArea t = new TriangleArea(2, 3);

            //covariant delegate 
            CovDelg del = r.ReturnRectArea;
            del();
            del = t.returnTraingleArea;
            del();


            //contravariant delegate
            ContDeleg cdel = PassRectArea;
            cdel(t);
            cdel = PassTriangleArea;
            cdel(t);
          
        }
    }
}
