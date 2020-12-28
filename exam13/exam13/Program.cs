using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, текст");
            string yourText = Console.ReadLine().ToLower();
            Console.WriteLine("Введите, пожалуйста, ключ");
            string keyWord = Console.ReadLine().ToLower();

            for (int i = 0; i < yourText.Length; i++)
            {
                char keychar = keyWord[i % keyWord.Length];
                Encryptor(yourText[i], keychar);
            }

            Console.WriteLine("");

            Console.WriteLine("Введите, пожалуйста, зашифрованный текст");
            yourText = Console.ReadLine().ToLower();
            Console.WriteLine("Введите, пожалуйста, ключ");
            keyWord = Console.ReadLine().ToLower();

            for (int i = 0; i < yourText.Length; i++)
            {
                char keychar = keyWord[i % keyWord.Length];
                Decryptor(yourText[i], keychar);
            }

            Console.ReadKey();
        }

        static void Encryptor(char inputChar, char keychar)
        {
            string symbols = "0123456789abcdefghijklmnopqrstuvwxyz !@#$%^&*()-_=+:;/?.,`~[]{}<>'";
            Console.Write(symbols[((symbols.IndexOf(inputChar) + symbols.IndexOf(keychar)) % symbols.Length)]);
        }

        static void Decryptor(char inputChar, char keychar)
        {
            string symbols = "0123456789abcdefghijklmnopqrstuvwxyz !@#$%^&*()-_=+:;/?.,`~[]{}<>'";
            Console.Write(symbols[((symbols.IndexOf(inputChar) - symbols.IndexOf(keychar) + symbols.Length) % symbols.Length)]);
        }
    }
}
