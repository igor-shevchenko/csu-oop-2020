namespace Shapes
{
    interface IShape
    {
        double GetArea();
        bool IsInside(Point point);
    }
}