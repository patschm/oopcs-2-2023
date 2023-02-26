using IEEE;

namespace Philips;

public class Lamp: IDevice
{
    public void Aan()
    {
        Console.WriteLine("De lamp gaat branden");
    }

    public void Activate()
    {
        Aan();
    }
}