namespace RadioDing;

delegate void Subscription(string msg);

internal class RadioStation
{
    public event Subscription? Message;

    public void Broadcast()
    {
        Console.WriteLine("Het station start de uitzening");
        Message?.Invoke("Hallo luisteraars");
    }
}
