namespace FlatGebouw;

class Lift
{
    public int CurrentFloor { get; set; }

    public void Call(int floor)
    {
        Console.WriteLine($"De lift zoemt naar de {floor}e verdieping");
        CurrentFloor = floor;
    }

}