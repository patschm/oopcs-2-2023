using ACME;
using Ajax;

namespace Ruimte;

internal class Program
{
    static void Main(string[] args)
    {
        Rookmelder rm = new Rookmelder();
        Sprinkler sp1 = new Sprinkler();
        Jan j = new Jan();

        rm.SmokeDetected += sp1.SpuitWater;
        rm.SmokeDetected += j.DoetIets;
        rm.RookDetected();
       // sp1.SpuitWater(); // Telt niet. Is fout!!!!!
    }
}