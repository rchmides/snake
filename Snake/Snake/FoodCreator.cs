using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidht, int mapHeight, char sym)
        {
            this.mapWidth = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }

        internal Point CreateFood(Snake snake)
        {
            int x;
            int y;
            do
            {
                x = this.random.Next(2, this.mapWidth - 2);
                y = this.random.Next(2, this.mapHeight - 2);
            }
            while (snake.FoodOnSnake(x, y));
            var food = new Point(x, y, this.sym);
            food.Draw();
            return food;
        }
    }
}
