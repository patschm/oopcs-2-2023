namespace TheCompany;

internal class ACME
{
    private List<IContract> werknemers = new List<IContract>();

    public void Hire(IContract employee)
    {
        werknemers.Add(employee);
    }

    public void StoomFluit()
    {
        Console.WriteLine("ACME Starts producing");
        foreach(IContract werknemer in werknemers)
        {
            werknemer.Werk();
        }
     
    }
         
}
