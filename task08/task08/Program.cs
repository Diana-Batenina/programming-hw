using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, знаменатель");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите, пожалуйста, число степеней знаменателя");
            int k = int.Parse(Console.ReadLine());
            double term;
            double sum = 0;

            while (k >= 0)
            {
                term = 1 / Math.Pow(n, k);
                sum = sum + term;
                k = k - 1;
            }

            Console.WriteLine($"Сумма = {sum}");
            Console.ReadLine();
        }
    }
}
