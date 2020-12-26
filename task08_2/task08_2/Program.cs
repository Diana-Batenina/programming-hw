using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, число элементов последовательности");
            int n = int.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            double sum = 0;
            
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите, пожалуйста, элемент №{i}");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            for (var i = 0; i < n; i++)
            {
                sum = sum + (Math.Pow((-1), i) * numbers[i]);
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
