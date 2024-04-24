namespace ConsoleApp2;

class TargetTypeMultiTarget : IAbilityHandler
{
    private static readonly Lazy<TargetTypeMultiTarget> _instance =
       new Lazy<TargetTypeMultiTarget>(
           () => new TargetTypeMultiTarget(), isThreadSafe: true
       );
    public static TargetTypeMultiTarget Instance
    {
        get { return _instance.Value; }
    }

    public void Execute()
    {
        Console.WriteLine("TargetTypeMultiTarget.Execute()");
    }

    public void Validate()
    {
        Console.WriteLine("TargetTypeMultiTarget.Validate()");
    }
}
