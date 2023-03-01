namespace TheCompany;

internal class Bokito: IContract, IContractBlijdorp
{
    void IContractBlijdorp.Werk()
    {
        Console.WriteLine("Maakt Blijdorp onveilig");
    }
    void IContract.Werk()
    {
        Werken();
    }

    public void Werken()
    {
        Console.WriteLine("Bokito ramt gasten in elkaar");
    }
}
