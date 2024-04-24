namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        Fireball fireball = new Fireball();
        ShitEverywhere shitEverywhere = new ShitEverywhere();

        Console.WriteLine("Fireball");
        fireball.Validate();
        fireball.Execute();
        Console.WriteLine();
        Console.WriteLine("ShitEverywhere");
        shitEverywhere.Validate();
        shitEverywhere.Execute();

        Console.ReadKey();
    }
}
