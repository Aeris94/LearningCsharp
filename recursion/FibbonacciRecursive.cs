using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static int FibbRecurssive(int n)
        {
            if(n <= 2)
            {
                return 1;
            }
            else
            {
                return (FibbRecurssive(n - 1) + FibbRecurssive(n - 2));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FibbRecurssive(8));
        }
    }
}
