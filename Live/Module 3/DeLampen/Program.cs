using LampCollectie;

namespace DeLampen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oerknal

            Lamp lm1 = new LampCollectie.Lamp();
            //lm1.intensiteit = 100;
            //lm1.kleur = ConsoleColor.Magenta;
            lm1.Aan();

            Lamp lm2 = new Lamp(200, ConsoleColor.Yellow);
            //lm2.kleur = ConsoleColor.Yellow;
            //lm2.intensiteit = 200;
            lm2.Aan();

            Lamp lm3 = new Lamp { Intensiteit = 400, Kleur = ConsoleColor.Green };
            //lm3.Intensiteit= 10000;
            Console.WriteLine(lm3.Intensiteit);
            lm3.Aan();


            // Big Crunch
        }
    }
}