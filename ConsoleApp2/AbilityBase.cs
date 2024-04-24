namespace ConsoleApp2;

abstract class AbilityBase<TargetType, DamageType>
    where TargetType : ITargetType, new()
    where DamageType : IDamageType, new()
{
    private TargetType _targetHandler = new TargetType();
    private DamageType _damageHandler = new DamageType();

    public virtual bool Validate()
    {
        _targetHandler.Validate();
        _damageHandler.Validate();
        return true;
    }

    public virtual void Execute()
    {
        _targetHandler.Execute();
        _damageHandler.Execute();
    }
}
