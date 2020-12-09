using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, целое число");
            int n = int.Parse(Console.ReadLine());
            var remain2 = n % 2;
            var remain3 = n % 3;
            bool a = (remain2 == 0) || (remain3 == 0);
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
