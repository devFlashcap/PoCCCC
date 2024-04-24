namespace ConsoleApp2;

class ShitEverywhere : AbilityBase<MultiTarget, NonDamaging>
{
    public ShitEverywhere()
    {
    }

    public override bool Validate()
    {
        base.Validate();
        Console.WriteLine("ShitEverywhere custom validation");
        return true;
    }

    public override void Execute()
    {
        base.Execute();
        Console.WriteLine("ShitEverywhere custom execution");
    }
}
