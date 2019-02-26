﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = getNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point getNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        public void handleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow && this.direction != Direction.RIGHT)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow && this.direction != Direction.LEFT)
                direction = Direction.RIGHT;
            if (key == ConsoleKey.UpArrow && this.direction != Direction.DOWN)
                direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow && this.direction != Direction.UP)
                direction = Direction.DOWN;
        }

        internal bool Eat(Point food)
        {
            Point head = getNextPoint();
            if (head.IsHit(food))
            {
                head.Draw();
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }

        internal bool FoodOnSnake(int x, int y)
        {
            foreach (var p in this.pList)
            {
                if (p.x == x && p.y == y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
