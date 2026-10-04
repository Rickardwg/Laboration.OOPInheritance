namespace OOPInheritance;

public class Dog : Animal
{
    public bool CanFetch { get; set; } = true;

    public Dog() { }

    public Dog(string name, int age, double height, double weight, bool isAlive, bool canFetch)
        : base(name, age, height, weight, isAlive)
    {
        CanFetch = canFetch;
    }

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
