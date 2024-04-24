namespace ConsoleApp2;

abstract class AbilityBase
{
    protected IEnumerable<IAbilityHandler> _abilityHandlers { get; }

    protected AbilityBase(params Type[] abilityHandlerTypes)
    {
        _abilityHandlers = abilityHandlerTypes.Select(handler => (IAbilityHandler)handler.GetProperty("Instance").GetValue(null));
    }

    public virtual void Execute()
    {
        Console.WriteLine("AbilityBase.Execute()");
        foreach (var abilityHandler in _abilityHandlers)
        {
            abilityHandler.Execute();
        }
    }

    public virtual void Validate()
    {
        Console.WriteLine("AbilityBase.Validate()");
        foreach (var abilityHandler in _abilityHandlers)
        {
            abilityHandler.Validate();
        }
    }
}
