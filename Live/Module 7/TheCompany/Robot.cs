
namespace TheCompany
{
    internal class Robot: IContract
    {
        public void Werk()
        {
            Werken();
        }

        public void Werken()
        {
            Console.WriteLine("Robot bliep bliept");
        }
    }
}
