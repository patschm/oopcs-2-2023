namespace TheCompany;

internal abstract class Employee : Person, IContract
{
    public void Werk()
    {
        Werken();
    }

    public abstract void Werken();

}
