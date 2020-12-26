using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04
{
    class Program
    {
        static void Main()
        {
            var x = GetValue();
            Console.WriteLine("x = " + x);

            Console.ReadKey();
        }
        static double GetValue()
        {
            return F(5, 7) * F(12, 8) * F(31, 2);
        }
        static double F(double a, double b)
        {
            return (a + Math.Sqrt(a)) / (b + Math.Sqrt(b));
        }
    }
}
