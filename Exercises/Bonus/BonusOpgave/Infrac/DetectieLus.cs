using IEEE;

namespace Infrac;

public class DetectieLus
{
    private IDevice[] devices = new IDevice[10];
    private event Action? Detecting;
    //private event EventHandler? Detected;

    public void Connect(Action a)
    {
        Detecting += a;
    }
    public void Connect(IDevice device)
    {
        for(int i = 0; i < devices.Length; i++)
        {
            if (devices[i] == null)
            {
                devices[i] = device;
                return;
            }
        }
    }
    public void Detect()
    {
        Console.WriteLine("Hmmmm. Wasda?");
        // Via Delegates
        Detecting?.Invoke();

        //Detected?.Invoke(this, new EventArgs());

        // Via Interfaces
        foreach(IDevice device in devices) 
        { 
            device?.Activate();
        }
    }
}