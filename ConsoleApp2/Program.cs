namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Fireball fireball = new Fireball();
        ShitEverywhere shitEverywhere = new ShitEverywhere();
        
        Console.WriteLine("FIREBALL");
        fireball.Validate();
        fireball.Execute();
        Console.WriteLine();
        Console.WriteLine("SHITEVERYWHERE");
        shitEverywhere.Validate();
        shitEverywhere.Execute();

        Console.ReadKey();
    }
}
