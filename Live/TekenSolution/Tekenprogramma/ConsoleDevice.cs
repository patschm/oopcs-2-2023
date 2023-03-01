
using ShapesLibrary;
using System.Drawing;
using System.IO;

namespace Tekenprogramma;

public class ConsoleDevice : IDevice
{
    public void DrawCirkel(ShapesLibrary.Point? p, Color color, int lineWidth, int radius)
    {
        Console.ForegroundColor = color.ToConsoleColor();
        Console.WriteLine(@$"Cirkel op positie {p} met lijndikte {lineWidth} en met straal {radius}");
        Console.ResetColor();
    }

    public void DrawRectangle(ShapesLibrary.Point? p, Color color, int lineWidth, int width, int height)
    {
        Console.ForegroundColor = color.ToConsoleColor();
        Console.WriteLine(@$"Rechthoek op positie {p} met lijndikte {lineWidth}, met hoogte {height} en breedte {width}");
        Console.ResetColor();
    }

    public void DrawTriangle(ShapesLibrary.Point? p, Color color, int lineWidth, int basis, int height, int angle)
    {
        Console.ForegroundColor = color.ToConsoleColor();
        Console.WriteLine(@$"Driehoek op positie {p} met lijndikte {lineWidth}, met basis {basis}, hoogte {height}, en hoek {angle}");
        Console.ResetColor();
    }
}
