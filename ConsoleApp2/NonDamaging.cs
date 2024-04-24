namespace ConsoleApp2;

class NonDamaging : IDamageType
{
    public bool Validate()
    {
        Console.WriteLine("Non-damagable validation");
        return true;
    }

    public void Execute()
    {
        Console.WriteLine("Non-damagable execution");
    }
}
