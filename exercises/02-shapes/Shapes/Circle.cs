using System;

namespace Shapes
{
    class Circle : IShape
    {
        private readonly Point center;
        private readonly double radius;

        public Circle(Point center, double radius)
        {
            if (radius <= 0 || radius > 100)
                throw new ArgumentException();

            this.center = center;
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public bool IsInside(Point point)
        {
            return center.GetDistanceTo(point) <= radius;
        }
    }
}