using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
class Snake : Figure
	{
		public Direction direction;

		public Snake( Point tail, int length, Direction _direction )
		{
			direction = _direction;
			pList = new List<Point>();
			for ( int i = 0; i < length; i++ )
			{
				Point p = new Point( tail );
				p.Move( i, direction );
				pList.Add( p );
			}
		}

		public void Move()
		{
			Point tail = pList.First();	  // возвращение первого елемента списка		
			pList.Remove( tail );         // удаление одной точки 
			Point head = GetNextPoint();  // заполнение значением которая возвращает ф-цию
			pList.Add( head );

			tail.Clear();
			head.Draw();
		}

		public Point GetNextPoint() // ф-ция вычисляет в какой точке окажется змейка в следующий момент
		{
			Point head = pList.Last();
			Point nextPoint = new Point( head );
			nextPoint.Move( 1, direction );
			return nextPoint;
		}

		public bool IsHitTail()
		{
			var head = pList.Last();
			for(int i = 0; i < pList.Count - 2; i++ )
			{
				if ( head.IsHit( pList[ i ] ) )
					return true;
			}
			return false;
		}

		public void ChangeOFdirection (ConsoleKey key)
		{
			if ( key == ConsoleKey.LeftArrow )
				direction = Direction.LeftArrow;
			else if ( key == ConsoleKey.RightArrow )
				direction = Direction.RightArrow;
			else if ( key == ConsoleKey.DownArrow )
				direction = Direction.DownArrow;
			else if ( key == ConsoleKey.UpArrow )
				direction = Direction.UpArrow;
		}

		public bool Eat( Point food )
		{
            

            Point head = GetNextPoint();
			if ( head.IsHit( food ) )
			{
				food.sym = head.sym;
				pList.Add( food );
				return true;
			}
			else
				return false;
		}
	}
}
