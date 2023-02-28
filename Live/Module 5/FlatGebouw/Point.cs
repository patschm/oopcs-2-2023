namespace FlatGebouw;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Point operator+(Point a, Point b)
    {
        return new Point { Y = a.Y + b.Y, X = a.X + b.X };
    }

    public void Show()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}
