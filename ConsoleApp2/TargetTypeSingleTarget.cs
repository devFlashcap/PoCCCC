namespace ConsoleApp2;

class TargetTypeSingleTarget : IAbilityHandler
{
    private static readonly Lazy<TargetTypeSingleTarget> _instance =
       new Lazy<TargetTypeSingleTarget>(
           () => new TargetTypeSingleTarget(), isThreadSafe: true
       );
    public static TargetTypeSingleTarget Instance
    {
        get { return _instance.Value; }
    }

    public void Execute()
    {
        Console.WriteLine("TargetTypeSingleTarget.Execute()");
    }

    public void Validate()
    {
        Console.WriteLine("TargetTypeSingleTarget.Validate()");
    }
}
