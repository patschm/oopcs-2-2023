namespace TheCompany;

internal class Program
{
    static void Main(string[] args)
    {
        Bokito b = new Bokito();
        //(b as IContractBlijdorp).Werk();
        Jordin j = new Jordin();
        Nikkie n = new Nikkie();
        Jan ja = new Jan();
        Robot rob = new Robot();
        ACME acme= new ACME();

        acme.Hire(ja);
        acme.Hire(j);
        acme.Hire(n);
        acme.Hire(b);
        acme.Hire(rob);

        acme.StoomFluit();
    }
}