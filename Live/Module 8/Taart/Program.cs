namespace Taart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patrick p = new();
            Elmar e = new();

            OpdrachtDel d = p.Bestelling;

            e.Execute(p.Bestelling);
            e.Execute(d);
            e.Execute(Explode);
            e.Execute(p);
        }

        static void Explode()
        {
            Console.WriteLine("Kaboooomm");
        }
    }
}