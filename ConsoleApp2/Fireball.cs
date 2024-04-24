namespace ConsoleApp2;

class Fireball : AbilityBase
{
    public Fireball()
        : base(typeof(TargetTypeSingleTarget), typeof(DamageTypeDamaging))
    {

    }

    public override void Execute()
    {
        base.Execute();
        Console.WriteLine("Fireball.Execute()");
    }

    public override void Validate()
    {
        base.Validate();
        Console.WriteLine("Fireball.Validate()");
    }
}
