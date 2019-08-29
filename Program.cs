using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
class Program
	{
		static void Main( string[] args )
		{
			Console.SetBufferSize( 80, 25 );

            Walls walls = new Walls(80, 25);
            walls.Draw();

            // отрисовка точек
            Point p = new Point( 4, 5, (char)GameObject.snakeTail);
			Snake snake = new Snake( p, 4, Direction.RightArrow );
			snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, (char)GameObject.apple);
            Point food = foodCreator.CreateFood();
            food.Draw();


            while (true)
			{
				if ( walls.IsHit(snake) || snake.IsHitTail() )
				{
					break;
				}
				if(snake.Eat(food) )
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep( 200 );
				if ( Console.KeyAvailable )
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.ChangeOFdirection( key.Key );
				}
			}
			WriteGameOver();
			Console.ReadLine();
      }


		static void WriteGameOver()
		{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(27, 10);
            Console.WriteLine("И Г Р А    О К О Н Ч Е Н А ");
            Console.SetCursorPosition(25, 15);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Нажмите Enter для продолжения!");
            Console.ReadLine();
            Console.Clear();
		}

	}
}
