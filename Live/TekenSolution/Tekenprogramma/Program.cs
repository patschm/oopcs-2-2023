using ShapesLibrary;
using System.Drawing;

namespace Tekenprogramma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Canvas canvas = new Canvas();

            Cirkel c = new Cirkel
            {
                Positie = new ShapesLibrary.Point { X = 10, Y = 20 },
                Kleur = Color.Blue,
                Lijndikte = 3,
                Straal = 100
            };

            canvas.Add(c);

            Rechthoek rh = new Rechthoek
            {
                Positie = new ShapesLibrary.Point { X = 100, Y = 200 },
                Kleur = Color.Red,
                Lijndikte = 4,
                Hoogte = 100,
                Breedte = 200
            };

            canvas.Add(rh);

            Driehoek dh = new Driehoek
            {
                Positie = new ShapesLibrary.Point { X = 50, Y = 100 },
                Kleur = Color.Green,
                Lijndikte = 2,
                Hoogte = 100,
                Basis = 200,
                Hoek = 60
            };

            canvas.Add(dh);

            Console.ReadLine();

        }
    }
}