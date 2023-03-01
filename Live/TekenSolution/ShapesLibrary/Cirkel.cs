namespace ShapesLibrary
{
    public class Cirkel: Figuur
    {
        public int Straal { get; set; }

        public override void Teken(IDevice device)
        {
            device.DrawCirkel(Positie, Kleur, Lijndikte, Straal);
        }
    }
}
