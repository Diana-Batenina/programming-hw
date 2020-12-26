using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, количество чисел в последовательности");
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите, пожалуйста, число №{i}");
                number[i] = int.Parse(Console.ReadLine());
                if (number[i] % 10 != 0)
                {
                    while (number[i] % 10 != 0)
                    {
                        Console.WriteLine("Число должно оканчиваться нулём");
                        number[i] = int.Parse(Console.ReadLine());
                    }
                }
            }

            int sum = 0;

            for (var i = 0; i < n; i++)
            {
                sum = sum + number[i];
            }

            double average = sum / n;

            Console.WriteLine($"Среднее арифметическое чисел = {average}");

            Console.ReadKey();
        }
    }
}
