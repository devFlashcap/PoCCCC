namespace ConsoleApp2;

class DamageTypeNonDamaging : IAbilityHandler
{
    private static readonly Lazy<DamageTypeNonDamaging> _instance =
       new Lazy<DamageTypeNonDamaging>(
           () => new DamageTypeNonDamaging(), isThreadSafe: true
       );
    public static DamageTypeNonDamaging Instance
    {
        get { return _instance.Value; }
    }

    public void Execute()
    {
        Console.WriteLine("DamageTypeNonDamaging.Execute()");
    }

    public void Validate()
    {
        Console.WriteLine("DamageTypeNonDamaging.Validate()");
    }
}
