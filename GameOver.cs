using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GameOver
    {
        public static void WriteGameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(27, 10);
            Console.WriteLine("И Г Р А    О К О Н Ч Е Н А ");
            Console.SetCursorPosition(27, 15);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Нажмите Enter для выхода!!!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
