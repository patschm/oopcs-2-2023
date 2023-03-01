namespace HetCern;

internal class Program
{
    static void Main(string[] args)
    {
        WillemKlein wk = new WillemKlein();
        SimonVdMeer sm = new SimonVdMeer();

        //wk.Bereken(sm.Add, 5, 6);
        //wk.Bereken(sm.Subtract, 5, 6);

        MathDel f1 = sm.Add;
        f1 += sm.Subtract;
        f1 += sm.Add;
        f1 -= sm.Add;

        foreach(var item in f1.GetInvocationList())
        {
            Console.WriteLine(  item.Method.Name);
        }

        int res = f1(1, 2);
        Console.WriteLine(res);
    }
}