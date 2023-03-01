

namespace TheCompany;

internal class Jan: Employee
{
    public override void Werken()
    {
        Console.WriteLine("Jan gaat bedient de stoomfluit");
        Console.Beep(1000, 2000);
    }
}
