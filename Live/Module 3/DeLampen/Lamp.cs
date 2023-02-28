namespace LampCollectie
{
    // Dit is de blauwdruk van een lamp
    // Is dus een custom type
    class Lamp
    {
        // Fields.
        // Hierin sla je de eigenschappen op.
        private int intensiteit = 100;
        //public ConsoleColor kleur = ConsoleColor.White;

        // Zo doet de Javaan en C+++-ert
        //public void SetIntensiteit(int intens)
        //{
        //    if (intens >= 0 && intens < 1000)
        //    {
        //        intensiteit = intens;
        //    }
        //}
        //public int GetIntensiteit()
        //{
        //    return intensiteit;
        //}

        // Proprties.
        // Gebruik properties om gecontroleerde toegang to je fields te verkrijgen.
        // Encapsulation
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

        // Auto Generating Property
        public ConsoleColor Kleur { get; set; } = ConsoleColor.White;


        // Methods
        // Hierin leg je gedrag vast.
        public void Aan()
        {
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"De lamp brandt met {Intensiteit} lumen");
            Console.ResetColor();
        }

        // Constructors.
        // Gebruik je om fields van een initiele waarde te voorzien.
        // Be careful. Use with caution
        public Lamp():this(100, ConsoleColor.Black)
        {
            
        }
        public Lamp(int intensity, ConsoleColor color)
        {
            this.Kleur = color;
            Intensiteit = intensity;
        }
    }
}