
namespace DeLampen
{
    // Overerving bevordertt het hergebruik.
    class TL : Lamp
    {
        public int Knippers { get; set; }

        // Met override maak ik dit gedrag polymorf.
        // Polymorfisme is generaliseren met behoud van specifiek gedrag.
        public override void Aan()
        {
            Knipperen();
            
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"De TL brandt met {Intensiteit} lumen");
            Console.ResetColor();
           // base.Aan();
        }
        private void Knipperen()
        {
            for (int i = 0; i < Knippers; i++)
            {
                Console.BackgroundColor = Kleur;
                Console.WriteLine("Knipper");
                Task.Delay(100).Wait();
                Console.ResetColor();
                Console.Clear();
                Task.Delay(100).Wait();
            }
        }
    }
}
