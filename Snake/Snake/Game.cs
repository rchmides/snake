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
            upperLine.Draw();

            HorizontalLine downLine = new HorizontalLine(1, 70, 20, '+');
            downLine.Draw();

            VerticalLine leftLine = new VerticalLine(0, 0, 20, '+');
            leftLine.Draw();

            VerticalLine rightLine = new VerticalLine(71, 0, 20, '+');
            rightLine.Draw();

            Point p = new Point(8, 10, '*');
            Snake snake = new Snake(p, 4, Direction.UP);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

            Console.ReadLine();
        }
    }
}
