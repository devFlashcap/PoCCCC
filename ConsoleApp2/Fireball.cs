namespace ConsoleApp2;

class Fireball : AbilityBase<SingleTarget, Damaging>
{
    public Fireball()
    {
    }

    public override bool Validate()
    {
        base.Validate();
        Console.WriteLine("Fireball custom validation");
        return true;
    }

    public override void Execute()
    {
        base.Execute();
        Console.WriteLine("Fireball custom execution");
    }
}
