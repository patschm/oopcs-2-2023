using System.Runtime.CompilerServices;

namespace FlatGebouw;

class Etage
{
    public int nummer = 0;
    public static Lift elevator = new Lift();

    public void CallElevator()
    {
       elevator.Call(nummer);
    }
    public void ShowElevatorStatus()
    {
        Console.WriteLine($"De lift staat op de {elevator.CurrentFloor}e verdieping");
    }
}
