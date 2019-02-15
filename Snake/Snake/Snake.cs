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
            Point p1 = new Point(12, 3, '*');
            p1.Draw();

            HorizontalLine upperLine = new HorizontalLine(0, 70, 0, '—');
            upperLine.Draw();

            HorizontalLine downLine = new HorizontalLine(0, 70, 20, '—');
            downLine.Draw();
            Console.ReadLine();
        }
    }
}
