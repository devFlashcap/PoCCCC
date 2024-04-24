namespace ConsoleApp2;

class MultiTarget : ITargetType
{
    public bool Validate()
    {
        Console.WriteLine("Multi target validation");
        return true;
    }
    public void Execute()
    {
        Console.WriteLine("Multi target execution");
    }
}
