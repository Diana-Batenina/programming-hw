using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите радиус окружности:");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Радиус окружности = " + r);
            Console.WriteLine("Длина окружности = " + Math.Round(2 * Math.PI * r, 3));
            Console.WriteLine("Площадь круга = " + Math.Round(Math.PI * r * r, 3));

            Console.ReadKey();
        }
    }
}
