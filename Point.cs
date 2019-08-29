using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	public class Point
	{
		public int x;
		public int y;
		public char sym;

		public Point(int x, int y, char sym)
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public Point(Point p)
		{
			x = p.x;
			y = p.y;
			sym = p.sym;
		}

		public void Move(int offset, Direction direction)
		{
			if(direction == Direction.RightArrow)
			{
				x = x + offset;
			}
			else if(direction == Direction.LeftArrow)
			{
				x = x - offset;
			}
			else if(direction == Direction.UpArrow)
			{
				y = y - offset;
			}
			else if(direction == Direction.DownArrow)
			{
				y = y + offset;
			}
		}

		public bool IsHit(Point p) // пересечение кординат текущий точки с той точкой котороя передалась в качестве аргумента
		{
			return p.x == this.x && p.y == this.y;
		}

		public void Draw()
		{
			Console.SetCursorPosition( x, y );
			Console.Write( sym );			
		}

		public void Clear()
		{
			sym = ' ';
			Draw();
		}

		public override string ToString()
		{
			return x + ", " + y + ", " + sym;
		}
	}
}
