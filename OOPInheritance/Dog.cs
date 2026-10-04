namespace OOPInheritance;

public class Dog(string name, int age, double height, double weight, bool isAlive, bool canFetch)
    : Animal(name, age, height, weight, isAlive)
{
    public bool CanFetch { get; set; } = canFetch;

    public override void MakeSound()
    {
        Console.WriteLine("Voff!");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} äter torrfoder.");
    }

    public void Fetch()
    {
        var message = CanFetch ? $"{Name} hämtade bollen." : $"{Name} är aningslös.";
        Console.WriteLine(message);
    }
}
