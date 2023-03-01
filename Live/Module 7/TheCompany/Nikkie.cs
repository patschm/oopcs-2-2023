namespace TheCompany;

internal class Nikkie: Employee
{
    public override void Werken()
    {
        RegeltHetVoedsel();
    }
    public void RegeltHetVoedsel()
    {
        Console.WriteLine("Nikkie regelt het eten");
    }
}
