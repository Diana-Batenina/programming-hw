using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, координаты точки");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("x = " + x);
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("y = " + y);

            bool checkX = (x >= -1) && (x <= 1.5);
            bool checkY = (y >= -0.5) && (y <= 2);
            if ((checkX == true) & (checkY == true))
                Console.WriteLine("Точка принадлежит указанной области");
            else
                Console.WriteLine("Точка не принадлежит указанной области");

            Console.ReadKey();
        }
    }
}
