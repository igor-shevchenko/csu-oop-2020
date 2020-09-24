using System;

namespace Shapes
{
    class Rectangle : IShape
    {
        private Point topLeft;
        private Point bottomRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            if (topLeft.X >= bottomRight.X)
                throw new ArgumentException();
            if (bottomRight.Y >= topLeft.Y)
                throw new ArgumentException();

            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        public double GetArea()
        {
            var width = bottomRight.X - topLeft.X;
            var height = topLeft.Y - bottomRight.Y;
            return width * height;
        }

        public bool IsInside(Point point)
        {
            var isInsideByX = point.X >= topLeft.X && point.X <= bottomRight.X;
            var isInsideByY = point.Y >= bottomRight.Y && point.Y <= topLeft.Y;
            return isInsideByY && isInsideByX;
        }
    }
}