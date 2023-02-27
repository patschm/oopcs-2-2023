namespace FuncProcs;

internal class Program
{
    static void Main(string[] args)
    {
        //var tmp = TelOp(1, 2, 3);
        var tmp = TelOp(y:100);
        ShowResult(tmp);

        int leng;
        DoeIets(out leng);
        WelcomeScreen("Patrick");
        var a = GeefGetal("A");
        var b = GeefGetal("B");
        // x = a
        Swap(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");
        var result = TelOp(a, b);
        ShowResult(result);
    }

    static void DoeIets(out int leng)
    {
        leng = 20;
        Console.WriteLine(leng);
    }

    static void Swap(ref int x, ref int y)
    {
        int hulp = x;
        x = y;
        y = hulp;
    }
    static void Swap(ref long x, ref long y)
    {
        long hulp = x;
        x = y;
        y = hulp;
    }
    // Procedure
    static void WelcomeScreen(string name)
    {
        Console.WriteLine($"Welcome {name}");
    }

    // Function
    static long GeefGetal(string label)
    {
        do
        {
            Console.WriteLine($"Geef een getal {label}");
            string? sNr = Console.ReadLine();
            int nr;
            if (int.TryParse(sNr, out nr))
            {
                return nr;
            }
            Console.WriteLine("Nie goe joh!");
            //long nr  = long.Parse(sNr!);
            //return nr;
        }
        while (true);
    }

    static int TelOp(int x, int y)
    {
        return x + y;
    }
    // Overload
    static long TelOp(long x = 1, long y = 9)
    {
        return x + y;
    }
    static long TelOp(params long[] nrs)
    {
        return nrs.Sum();
    }

    static void ShowResult(long val)
    {
        Console.WriteLine($"Het resultaat is {val}");
    }
}