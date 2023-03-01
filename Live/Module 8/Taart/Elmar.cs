
namespace Taart
{
    //delegate void OpdrachtDel();

    internal class Elmar
    {
        public void Execute(OpdrachtDel iets)
        {
            Console.WriteLine("Elmar doet hetvolgende via delegates:");
            iets();

        }
        public void Execute(IOpdracht iets)
        {
            Console.WriteLine("Elmar doet hetvolgende via interfaces:");
            iets.DoeIets();

        }
    }
}
