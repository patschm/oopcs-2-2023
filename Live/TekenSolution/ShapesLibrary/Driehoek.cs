namespace ShapesLibrary
{
    public class Driehoek: Figuur
    {
        public int Basis { get; set; }
        public int Hoogte { get; set; }
        public int Hoek { get; set; }

        public override void Teken(IDevice device)
        {
           device.DrawTriangle(Positie, Kleur, Lijndikte, Basis, Hoogte, Hoek);
        }
    }
}
