
using System.IO;

namespace ShapesLibrary
{
    public  class Rechthoek: Figuur
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }

        public override void Teken(IDevice device)
        {
            device.DrawRectangle(Positie, Kleur, Lijndikte, Breedte, Hoogte);
        }
    }
}
