using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, позицию белого короля");
            var whiteKingPosition = Console.ReadLine();
            Console.WriteLine("Введите, пожалуйста, позицию чёрной ладьи");
            var blackRookPosition = Console.ReadLine();

            if (CheckPosition(whiteKingPosition, blackRookPosition))
            {
                Console.WriteLine("Введите ход белого короля");
                var whiteKingMove = Console.ReadLine();
                if (CanKingMakeSafeMove(whiteKingMove, whiteKingMove, blackRookPosition))
                    Console.WriteLine("Король может ходить");
                else
                    Console.WriteLine("Король не может ходить");
            }
            else
                Console.WriteLine("Начальная расстановка фигур некорректна");

            Console.ReadKey();
        }

        static void GetCoordinates(string position, out int x, out int y)
        {
            x = (int)position[0] - 0x60;
            y = int.Parse(position[1].ToString());
        }

        //King and Rook

        static bool CanKingMakeMove(string start, string end)
        {
            if (start == end)
                return false;
            
            int startX, startY, endX, endY;

            GetCoordinates(start, out startX, out startY);
            GetCoordinates(end, out endX, out endY);

            return Math.Abs(endX - startX) <= 1 && Math.Abs(endY - startY) <= 1;
        }

        static bool CanRookMakeMove(string start, string end)
        {
            if (start == end)
                return false;

            int startX, startY, endX, endY;

            GetCoordinates(start, out startX, out startY);
            GetCoordinates(end, out endX, out endY);

            return startX == endX || startY == endY;
        }

        static bool CheckPosition (string whitePosition, string blackPosition)
        {
            return whitePosition != blackPosition && !CanKingMakeMove(whitePosition, blackPosition) && !CanRookMakeMove(blackPosition, whitePosition);
        }

        static bool CanKingMakeSafeMove (string kingStartPosition, string kingNewPosition, string rookPosition)
        {
            return CanKingMakeMove(kingStartPosition, kingNewPosition) && !CanRookMakeMove(rookPosition, kingNewPosition);
        }
    }
}
