using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static int FactorialRecurssive(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else return n * FactorialRecurssive(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FactorialRecurssive(3));
        }
    }
}
