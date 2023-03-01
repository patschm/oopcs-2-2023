namespace TheCompany;

internal class Jordin: Employee
{
    public override void Werken()
    {
        Assembleert();
    }
    public void Assembleert()
    {
        Console.WriteLine("Jordin rammelt wat dingen in elkaar");
    }
}
