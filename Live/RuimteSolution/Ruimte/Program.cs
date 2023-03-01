using ACME;
using Ajax;

namespace Ruimte;

internal class Program
{
    static void Main(string[] args)
    {
        Rookmelder rm = new Rookmelder();
        Sprinkler sp1 = new Sprinkler();


        rm.RookDetected();
       // sp1.SpuitWater(); // Telt niet. Is fout!!!!!
    }
}