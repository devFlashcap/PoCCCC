namespace ConsoleApp2;

class DamageTypeDamaging : IAbilityHandler
{
    private static readonly Lazy<DamageTypeDamaging> _instance =
       new Lazy<DamageTypeDamaging>(
           () => new DamageTypeDamaging(), isThreadSafe: true
       );
    public static DamageTypeDamaging Instance
    {
        get { return _instance.Value; }
    }

    public void Execute()
    {
        Console.WriteLine("DamageTypeDamaging.Execute()");
    }

    public void Validate()
    {
        Console.WriteLine("DamageTypeDamaging.Validate()");
    }
}
