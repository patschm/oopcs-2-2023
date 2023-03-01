namespace HetCern;

delegate int MathDel(int a, int b);

internal class WillemKlein
{
    public void Bereken(MathDel fun, int a, int b)
    {
        Console.WriteLine("Willem Klein rekent.....");
        int result = fun(a,b);

        Console.WriteLine($"Willem kraait: Het antwoord is {result}");
    }
}
