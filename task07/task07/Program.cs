using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, значение x");
            var x = double.Parse(Console.ReadLine());
            double f;

            if (x < 0)
            {
                f = 0;
                Console.WriteLine($"f(x) = {f}");
            }
            else
                if (x == 0)
                {
                    f = x;
                    Console.WriteLine($"f(x) = {f}");
                }
            else
            {
                f = x * x;
                Console.WriteLine($"f(x) = {f}");
            }

            Console.ReadKey();
        }
    }
}
