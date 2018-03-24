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

    class TrangleArea : RectArea
    {
        public TrangleArea returnTraingleArea()
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
            TrangleArea t = new TrangleArea();

            CovDelg del = new CovDelg(r.returnRectArea);
            del();
            del = t.returnTraingleArea;
            del();
        }
    }
}
