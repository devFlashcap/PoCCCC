namespace ConsoleApp2;

class Damaging : IDamageType
{
    public bool Validate()
    {
        Console.WriteLine("Damagable validation");
        return true;
    }

    public void Execute()
    {
        Console.WriteLine("Damagable execution");
    }
}
