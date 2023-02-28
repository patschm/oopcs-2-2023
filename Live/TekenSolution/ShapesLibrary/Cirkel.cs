namespace ShapesLibrary
{
    public class Cirkel: Figuur
    {
        public int Straal { get; set; }

        public override void Teken()
        {
            Console.ForegroundColor = Kleur.ToConsoleColor();
            Console.WriteLine(@$"Cirkel op positie {Positie} met lijndikte {Lijndikte} en met straal {Straal}");
            Console.ResetColor();
        }
    }
}
