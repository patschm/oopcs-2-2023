using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace Basics;

internal class Program
{
    static void Main(string[] args)
    {
        //Variables();
        //Expressions();
        //Nulbaar();
        //JumpVooruit();
        //JumpAchteruit();
        //Arrays();
        DeStringen();
    }

    static void DeStringen()
    {
        //string values = "";
        StringBuilder values = new StringBuilder();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for(int i = 0; i < 100000; i++)
        {
            //values += i;
            values.Append(i);
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);
    }

    static void Arrays()
    {
        int[] nummers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        nummers[0] = 1;

        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        int[][] jagged= new int[5][];
        jagged[0] = new int[10];
        jagged[1] = new int[2];
        jagged[2] = new int[20];
        jagged[3] = new int[12];

        Console.WriteLine(jagged[2][3]);


        Console.WriteLine(matrix[1,1]);

        for(int i = 0; i < nummers.Length; i++) 
        { 
            int tmp = nummers[i];
            Console.WriteLine(tmp);
        }
        // Iterator Design pattern
        foreach(int tmp in nummers)
        {
            Console.WriteLine( tmp);
        }

        List<int> list = new List<int>();
        list.Add(1);
        Dictionary<string, int> lookup = new Dictionary<string, int>();
        lookup["een"] = 1;
    }

    static void JumpAchteruit()
    {
        // De loopjes

        // De for-loop gebruik je als je precies weet hoe vaak je iets
        // moet herhalen.
        int x = 0;
        for (x = 0; x < 10; x++)
        {
            if (x == 5) continue;
            Console.WriteLine(x);
        }

        // Gebruik while als je niet weet hoe vaak je iets moet herhalen.
        // Kan 0 of meer keer worden uitgevoerd.
        while (x < 20)
        {
            x++;
            Console.WriteLine($"While {x} < 20");
            Console.WriteLine("While {0} < 20", x);
        }

        // Gebruik while als je niet weet hoe vaak je iets moet herhalen.
        // Minimaal 1 keer uitgevoerd.
        do
        {
            x++;
            Console.WriteLine($"While {x} < 20");
        }
        while (x < 30);

    }

    static void JumpVooruit()
    {
        int nr = 5;

        switch (nr)
        {
            case 0:
                Console.WriteLine("nul");
                break;
            case 1:
            case 2:
            case 3:
                Console.WriteLine("een, twee of drie");
                break;
            default:
                Console.WriteLine("Iets anders");
                break;
        }


        if (true)
        {

        }
        else
        {

        }
    }

    static void Nulbaar()
    {
        string? name = DoeIets();


        Console.WriteLine(name?.Length);
    }

    static string? DoeIets()
    {
        return null;
    }

    static void Expressions()
    {
        //double result = 4 / 5;
        int result = 1 & 2;
        Console.WriteLine(result);

        bool goed = true | DuurtLang();

        int? age = null;
        Console.WriteLine(age?.GetType());

        result += 3;

        int a = 1000;
        //checked 
        {
            byte b = (byte)a;
            //byte c = a as byte;
            Console.WriteLine(b is byte);
        }
    }

    static void Variables()
    {
        int age = 10;
        string name = "Patrick";
        bool isOk = false;
        {
            {
                {
                    string last = "Schmidt";
                }
            }
        }
        //Console.WriteLine(last);

        Console.WriteLine(isOk);
    }

    static bool DuurtLang()
    {
        Console.WriteLine("Doet het");
        return true;
    }
}