using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, значение первого элемента геометрической прогрессии");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите, пожалуйста, значение знаменателя геометрической прогрессии");
            double q = double.Parse(Console.ReadLine());


            Console.WriteLine();
        }

        static void GetArrayElements(double p, double q)
        {
            double[] GeometricProgression = new double[19];

            GeometricProgression[0] = p;

            for (var i = 1; i < 20; i++)
            {
                GeometricProgression[i] = p * q;
            }
        }
    }
}
