using System;

namespace Shapes
{
    class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            if (Math.Abs(x) > 100 || Math.Abs(y) > 100)
                throw new ArgumentException();

            X = x;
            Y = y;
        }

        public double GetDistanceTo(Point otherPoint)
        {
            return Math.Sqrt(Math.Pow(X - otherPoint.X, 2) + Math.Pow(Y - otherPoint.Y, 2));
        }
    }
}