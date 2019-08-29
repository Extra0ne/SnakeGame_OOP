using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake._123
{
  public class SnakeDisplay
    {
        public SnakeDisplay()
        {
            Point p = new Point(4, 5, (char)GameObject.snakeTail);
            Snake snake = new Snake(p, 4, Direction.RightArrow);
            snake.Draw();
        }
    }
}
