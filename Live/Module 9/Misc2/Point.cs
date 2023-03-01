namespace Misc2;

internal class Point<T, U>
{
    public T X { get; set; }
    public U Y { get; set; }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
