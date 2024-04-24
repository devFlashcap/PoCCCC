namespace ConsoleApp2;

class ShitEverywhere : AbilityBase
{
    public ShitEverywhere()
        : base(typeof(TargetTypeMultiTarget), typeof(DamageTypeNonDamaging))
    {

    }

    public override void Execute()
    {
        base.Execute();
        Console.WriteLine("ShitEverywhere.Execute()");
    }

    public override void Validate()
    {
        base.Validate();
        Console.WriteLine("ShitEverywhere.Validate()");
    }
}
