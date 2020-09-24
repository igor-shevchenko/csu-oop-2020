using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var center = new Point(0, 0);
            var circle = new Circle(center, 10);
            
            Console.WriteLine(circle.GetArea());

            Console.WriteLine(circle.IsInside(new Point(0, 0)));
            Console.WriteLine(circle.IsInside(new Point(10, 0)));
            Console.WriteLine(circle.IsInside(new Point(5, 5)));
            Console.WriteLine(circle.IsInside(new Point(10, 10)));

            var square = new Rectangle(new Point(-1, 1), new Point(1, -1));

            Console.WriteLine(square.GetArea());

            Console.WriteLine(square.IsInside(new Point(0, 0)));
            Console.WriteLine(square.IsInside(new Point(1, 0)));
            Console.WriteLine(square.IsInside(new Point(2, 2)));
        }
    }
}
