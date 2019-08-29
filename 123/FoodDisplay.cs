using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class FoodDisplay 
    {
        public FoodDisplay()
        {
            FoodCreator foodCreator = new FoodCreator(80, 25, (char)GameObject.apple);
            Point food = foodCreator.CreateFood();
            food.Draw();
        }

    }
}
