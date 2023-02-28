
using System.IO;

namespace ShapesLibrary
{
    public  class Rechthoek: Figuur
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }

        public override void Teken()
        {
            Console.ForegroundColor = Kleur.ToConsoleColor();
            Console.WriteLine(@$"Rechthoek op positie {Positie} met lijndikte {Lijndikte}, met hoogte {Hoogte} en breedte {Breedte}");
            Console.ResetColor();
        }
    }
}
