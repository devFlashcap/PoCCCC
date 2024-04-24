namespace ConsoleApp2;

class SingleTarget : ITargetType
{
    public bool Validate()
    {
        Console.WriteLine("Single target validation");
        return true;
    }
    public void Execute()
    {
        Console.WriteLine("Single target execution");
    }
}
