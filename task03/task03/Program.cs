using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите, пожалуйста, число x:");
            var x = double.Parse(Console.ReadLine());

            var y = F(x);

            Console.WriteLine("f(x) = " + y);
            Console.ReadKey();
        }

        static double F(double x)
        {
            return (x + (2 + Math.Cos(x)) / Math.Pow(x, 2)) / (x + (1 / (Math.Sqrt(Math.Pow(x, 2) + 10))));
        }
    }
}