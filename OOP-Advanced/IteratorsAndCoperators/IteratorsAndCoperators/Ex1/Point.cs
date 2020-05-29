using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    public class Point : IComparable<Point>
    {
        private int x;
        private int y; 

        public Point(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }


        public int CompareTo(Point otherPoint)
        {
            if (this.X != otherPoint.X)
            {
                return (this.X - otherPoint.X);
            }
            if (this.Y != otherPoint.Y)
            {
                return (this.Y - otherPoint.Y);
            }
            return 0;
        }

        public IComparable Comparable()
        {
            return null;
        }
    }
}
