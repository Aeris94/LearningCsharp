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
        public RectArea returnRectArea()
        {
            Console.WriteLine("Returninh RectArea object.");
            return this;
        }
    }

    class TriangleArea : RectArea
    {
        public TriangleArea returnTraingleArea()
        {
            Console.WriteLine("Returning TriangleArea object.");
            return this;
        }
    }


    class Program
    {
        public delegate RectArea CovDelg();

        static void Main(string[] args)
        {
            RectArea r = new RectArea();
            TriangleArea t = new TriangleArea();

            CovDelg del = new CovDelg(r.returnRectArea);
            del();
            del = t.returnTraingleArea;
            del();
        }
    }
}
