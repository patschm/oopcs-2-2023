using System.Threading.Channels;

namespace EvolutieTheorie;

internal class Program
{
    static void Main(string[] args)
    {
        // NET 1.0/1.1 (2002.2003)
        MathDel m1 = new MathDel(Add);
        int result = m1(1, 2);

        // NET 2.0 (2005)
        MathDel m2 = Add;
        result = m2(2, 3);

        int c = 10;

        MathDel m3 = delegate (int a, int b)
            {
                return a + b + c;
            };
        result = m3(4, 5);

        // NET 3.0 e.v, (2007)
        MathDel m4 =  (a, b) =>  a + b + c;
        result = m4(6, 7);

        // Procedures
        // Action
        Action<int> a1 = Console.WriteLine;
        //a1(result);

        // Functions
        // Func
        Func<int, int, int> m5 = Add;
        result = m5(8,9);
       


        Console.WriteLine($"Het result is {result}");
    }


    static int Add(int a, int b)
    {
        return a + b;
    }
}

delegate int MathDel(int x, int y);