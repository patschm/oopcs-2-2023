using System.Collections;

namespace Misc2;

internal class Program
{
    static void Main(string[] args)
    {
       //ArrayList list = new ArrayList();
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        //list.Add("3");

        foreach (int i in list)
        {
            Console.WriteLine(i);
        }


        string aa = "10";
        string bb = "20";

        Console.WriteLine($"a={aa}, b={bb}");
        Swap(ref aa, ref bb);
        Console.WriteLine($"a={aa}, b={bb}");

        Point<float, int> pf = new Point<float, int> { Y = 20, X = 40 };
        Console.WriteLine(  pf);
        //Point<double> pd = pf;
    }

    static void Swap<Tik>(ref Tik a, ref Tik b) //where Tik: ICloneable
    {
        Tik tmp = a;
        a = b;
        b = tmp;
    }

    //static void Swap(ref int a, ref int b)
    //{
    //    int tmp = a;
    //    a = b;
    //    b = tmp;
    //}
    //static void Swap(ref long a, ref long b)
    //{
    //    long tmp = a;
    //    a = b;
    //    b = tmp;
    //}
    //static void Swap(ref float a, ref float b)
    //{
    //    float tmp = a;
    //    a = b;
    //    b = tmp;
    //}
}