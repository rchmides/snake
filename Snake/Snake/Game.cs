using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Game
    {
        static void Main(string[] args)
        {

            HorizontalLine upperLine = new HorizontalLine(1, 70, 0, '+');
            HorizontalLine downLine = new HorizontalLine(1, 70, 20, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 20, '+');
            VerticalLine rightLine = new VerticalLine(71, 0, 20, '+');
            upperLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(8, 10, '*');
            Snake snake = new Snake(p, 4, Direction.UP);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.handleKey(key.Key);
                }
                Thread.Sleep(80);
                snake.Move();
            }

        }
    }
}
