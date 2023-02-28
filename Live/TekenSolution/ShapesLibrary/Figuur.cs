using System.Drawing;

namespace ShapesLibrary
{
    public abstract class Figuur
    {
        public Point? Positie { get; set; }
        public int Lijndikte { get; set; }
        public Color Kleur { get; set; }

        public abstract void Teken();
    }
}
