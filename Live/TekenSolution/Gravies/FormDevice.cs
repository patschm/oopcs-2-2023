using System;
using System.Drawing;


namespace Gravies;

public class FormDevice : ShapesLibrary.IDevice
{
    private readonly Graphics graph;

    public FormDevice(Graphics graph)
    {
        this.graph = graph;
    }

    public void DrawCirkel(ShapesLibrary.Point? point, Color color, int lineWidth, int radius)
    {
        using (Pen p = new Pen(color, lineWidth))
            graph.DrawArc(p, point.X, point.Y, radius, radius, 0, 360);
    }

    public void DrawRectangle(ShapesLibrary.Point? point, Color color, int lineWidth, int width, int height)
    {
        using (Pen p = new Pen(color, lineWidth))
            graph.DrawRectangle(p, point.X, point.Y, width, height);
    }

    public void DrawTriangle(ShapesLibrary.Point? point, Color color, int lineWidth, int basis, int height, int angle)
    {
        using (Pen p = new Pen(color, lineWidth))
        {
            Point[] points = new Point[3];
            points[0] = new Point(point.X, point.Y);
            points[1] = new Point(point.X + basis, point.Y);
            double hoekRads = angle / 2 * Math.PI;
            int delta = (int)(height / Math.Tan(hoekRads));
            points[2] = new Point(point.X + delta, point.Y + height);
            //graph.DrawPolygon(p, points);
        }
    }
}
