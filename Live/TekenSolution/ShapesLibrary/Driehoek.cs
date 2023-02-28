namespace ShapesLibrary
{
    public class Driehoek: Figuur
    {
        public int Basis { get; set; }
        public int Hoogte { get; set; }
        public int Hoek { get; set; }

        public override void Teken()
        {
            Console.ForegroundColor = Kleur.ToConsoleColor();
            Console.WriteLine(@$"Driehoek op positie {Positie} met lijndikte {Lijndikte}, met basis {Basis}, hoogte {Hoogte}, en hoek {Hoek}");
            Console.ResetColor();
        }
    }
}
