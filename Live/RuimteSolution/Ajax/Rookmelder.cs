namespace Ajax;

public class Rookmelder
{
    public event SmokeEvent? SmokeDetected;

    public void RookDetected()
    {
        Console.WriteLine("Hmmm.Wasda?");
        SmokeDetected?.Invoke();

    }
}