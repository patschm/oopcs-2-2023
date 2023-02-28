namespace DeLampen
{
    abstract class Lamp
    {
        private int intensiteit = 100;
        
        public int Intensiteit
        {
            set
            {
                if (value >= 0 && value < 1000)
                {
                    intensiteit = value;
                }
            }
            get
            {
                return intensiteit;
            }
        }
        public ConsoleColor Kleur { get; set; } = ConsoleColor.White;

        // Met virtual geef je aan dat dit gedrag polymorf-ready is
        //public virtual void Aan()
        //{
        //    Console.BackgroundColor = Kleur;
        //    Console.WriteLine($"De lamp brandt met {Intensiteit} lumen");
        //    Console.ResetColor();
        //}

        // Met abstract geef je aan dat een afgeleide het gedrag MOET overschrijven 
        // (virtual is vrijblijvend). Daarmee wordt wel de hele class abstract.
        public abstract void Aan();
    }
}