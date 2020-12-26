using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 5.1");
            Console.WriteLine("");
            Console.WriteLine("Введите, пожалуйста, текст");
            var text = Console.ReadLine();
            Console.WriteLine("Транслитерация:");
            Console.WriteLine(Transliterate(text));

            Console.WriteLine("");
            Console.WriteLine("Задание 5.2");
            Console.WriteLine("");
            var vertikal = "вертикаль";
            var tir = vertikal.Substring(3, 2) + vertikal.Substring(2, 1);
            var vetka = vertikal.Substring(0, 2) + vertikal.Substring(3, 1) + vertikal.Substring(5, 2);
            Console.WriteLine("Данное слово - " + vertikal);
            Console.WriteLine("Первое слово - " + tir);
            Console.WriteLine("Второе слово - " + vetka);

            Console.ReadKey();
        }

        static string Transliterate(string text) 
        {
            var result = text.ToUpper();

            result = result.Replace('А', 'A');
            result = result.Replace('Б', 'B');
            result = result.Replace('В', 'V');
            result = result.Replace('Г', 'G');
            result = result.Replace('Д', 'D');
            result = result.Replace('Е', 'E');
            result = result.Replace('Ё', 'E');
            result = result.Replace("Ж", "ZH");
            result = result.Replace('З', 'Z');
            result = result.Replace('И', 'I');
            result = result.Replace('Й', 'I');
            result = result.Replace('К', 'K');
            result = result.Replace('Л', 'L');
            result = result.Replace('М', 'M');
            result = result.Replace('Н', 'N');
            result = result.Replace('О', 'O');
            result = result.Replace('П', 'P');
            result = result.Replace('Р', 'R');
            result = result.Replace('С', 'S');
            result = result.Replace('Т', 'T');
            result = result.Replace('У', 'U');
            result = result.Replace('Ф', 'F');
            result = result.Replace("Х", "KH");
            result = result.Replace("Ц", "TS");
            result = result.Replace("Ч", "CH");
            result = result.Replace("Ш", "SH");
            result = result.Replace("Щ", "SHCH");
            result = result.Replace("Ъ", "IE");
            result = result.Replace('Ы', 'Y');
            result = result.Replace("Ь", "");
            result = result.Replace('Э', 'E');
            result = result.Replace("Ю", "IU");
            result = result.Replace("Я", "IA");
            return result;
        }
    }
}
