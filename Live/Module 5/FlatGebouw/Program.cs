namespace FlatGebouw;

internal class Program
{
    static void Main(string[] args)
    {
        //DeLift();
        HetPunt();
        
    }

    private static void HetPunt()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = new Point { Y = 20, X = 10 };

        Point p3 = p1 + p2;

        p1.Show();
        p2.Show();
        p3.Show();
    }

    private static void DeLift()
    {
        Etage.elevator.Call(200);

        Etage[] flat = new Etage[40];
        for (int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage { nummer = i };
        }

        flat[24].CallElevator();

        foreach (Etage et in flat)
        {
            et.ShowElevatorStatus();
        }
    }
}