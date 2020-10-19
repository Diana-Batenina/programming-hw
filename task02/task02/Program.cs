using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите, пожалуйста, трёхзначное число:");
            int numberABC = int.Parse(Console.ReadLine());
            Console.WriteLine("Исходное число: " + numberABC);
            int c = numberABC % 10;
            int ab = numberABC / 10;
            int b = ab % 10;
            int a = ab / 10;
            Console.WriteLine("Полученное число: " + c + b + a);

            Console.ReadKey();
        }
    }
}
