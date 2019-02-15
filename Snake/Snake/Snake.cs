using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(71, 21);
            Console.SetWindowSize(71, 21);

            Point p1 = new Point(12, 3, '*');
            p1.Draw();

            HorizontalLine upperLine = new HorizontalLine(1, 70, 0, '+');
            upperLine.Draw();

            HorizontalLine downLine = new HorizontalLine(1, 70, 20, '+');
            downLine.Draw();

            VerticalLine leftLine = new VerticalLine(0, 0, 20, '+');
            leftLine.Draw();

            VerticalLine rightLine = new VerticalLine(71, 0, 20, '+');
            rightLine.Draw();

            Console.ReadLine();
        }
    }
}
