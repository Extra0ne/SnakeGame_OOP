using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake._123
{
  public class WallsDisplay
    {

        public WallsDisplay()
        {
            Walls walls = new Walls(80, 25);
            walls.Draw();
        }
    }
}
