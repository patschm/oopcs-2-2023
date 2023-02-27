namespace CustomTypes
{

    internal class Program
    {
        static void Main(string[] args)
        {
            WeekDag dag = WeekDag.Woensdag;
            WeekDag dag2 = (WeekDag)3;
            Console.WriteLine(dag);
            Console.WriteLine((int)dag);
            Console.WriteLine(dag2);
        }
    }

    // Custom type.
    // De enum geeft duiding aan een getal.
    enum WeekDag:ulong
    {
        Maandag = 1,
        Dinsdag = 2,
        Woensdag = 4,
        Donderdag = 8,
        Vrijdag = 16,
        Zaterdag = 32,
        Zondag = 64
    }
}