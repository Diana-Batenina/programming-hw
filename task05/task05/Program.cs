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
            Console.WriteLine("Введите, пожалуйста, строку");
            Translit translit = new Translit();
            string firstString = Console.ReadLine();
            string translitedString = translit.TranslitedString(firstString);
            Console.WriteLine($"Переведённая строка - {translitedString}");

            Console.WriteLine("");
            Console.WriteLine("Задание 5.2");
            Console.WriteLine("");
            Console.WriteLine("Данное слово - «вертикаль»");

            Console.Write("Первое слово - ");
            Console.Write("вертикаль"[3]);
            Console.Write("вертикаль"[4]);
            Console.WriteLine("вертикаль"[2]);

            Console.Write("Второе слово - ");
            Console.Write("вертикаль"[0]);
            Console.Write("вертикаль"[1]);
            Console.Write("вертикаль"[3]);
            Console.Write("вертикаль"[5]);
            Console.Write("вертикаль"[6]);

            Console.ReadKey();
        }
        public class Translit
        {
            Dictionary<string, string> dictionaryChar = new Dictionary<string, string>()
            {
                {"A", "А"},
                {"а", "a"},
                {"Б", "B"},
                {"б", "b"},
                {"В", "V"},
                {"в", "v"},
                {"Г", "G"},
                {"г", "g"},
                {"Д", "D"},
                {"д", "d"},
                {"Е", "E"},
                {"е", "e"},
                {"Ё", "E"},
                {"ё", "e"},
                {"Ж", "ZH"},
                {"ж", "zh"},
                {"З", "Z"},
                {"з", "z"},
                {"И", "I"},
                {"и", "i"},
                {"Й", "I"},
                {"й", "i"},
                {"К", "K"},
                {"к", "k"},
                {"Л", "L"},
                {"л", "l"},
                {"М", "M"},
                {"м", "m"},
                {"Н", "N"},
                {"н", "n"},
                {"О", "O"},
                {"о", "o"},
                {"П", "P"},
                {"п", "p"},
                {"Р", "R"},
                {"р", "r"},
                {"С", "S"},
                {"с", "s"},
                {"Т", "T"},
                {"т", "t"},
                {"У", "U"},
                {"у", "u"},
                {"Ф", "F"},
                {"ф", "f"},
                {"Х", "KH"},
                {"х", "kh"},
                {"Ц", "TS"},
                {"ц", "ts"},
                {"Ч", "CH"},
                {"ч", "ch"},
                {"Ш", "SH"},
                {"ш", "sh"},
                {"Щ", "SHCH"},
                {"щ", "shch"},
                {"Ъ", "IE"},
                {"ъ", "ie"},
                {"Ы", "Y"},
                {"ы", "y"},
                {"Ь", null},
                {"ь", null},
                {"Э", "E"},
                {"э", "e"},
                {"Ю", "IU"},
                {"ю", "iu"},
                {"Я", "IA"},
                {"я", "ia"}
            };
            public string TranslitedString(string source)
            {
                var result = "";
                foreach (var ch in source)
                {
                    var ss = "";
                    if (dictionaryChar.TryGetValue(ch.ToString(), out ss))
                    {
                        result += ss;
                    }
                    else result += ch;
                }
                return result;
            }
        }
}
}
