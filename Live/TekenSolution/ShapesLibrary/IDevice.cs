using System.Drawing;

namespace ShapesLibrary;

public interface IDevice
{
    void DrawCirkel(Point? p, Color color, int lineWidth, int radius);
    void DrawRectangle(Point? p, Color color, int lineWidth, int width, int height);
    void DrawTriangle(Point? p, Color color, int lineWidth, int basis, int height, int angle);
}
