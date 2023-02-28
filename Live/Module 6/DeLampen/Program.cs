namespace DeLampen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oerknal

            //Lamp lm1 = new Lamp { Intensiteit = 200, Kleur=ConsoleColor.Green };        
            //lm1.Aan();

            // Generaliseren.
            Lamp t1 = new TL { Intensiteit = 300, Kleur=ConsoleColor.Red , Knippers=4};

            TL t2 = t1 as TL;
            TL t3 = (TL)t1;
            //t2.Aan();
            t1.Aan();

            // Big Crunch
        }
    }
}