using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taart
{
    internal class Patrick : IOpdracht
    {
        public void Bestelling()
        {
            Console.WriteLine("2x Rijstvlaai");
            Console.WriteLine("2x Roomtaart");
            Console.WriteLine("3x Aardbei");
            Console.WriteLine("2x Chocolade");
        }

        public void DoeIets()
        {
            Bestelling();
        }
    }
}
