namespace OOPInheritance.Models;

public class Fox : Animal
{
    public bool IsTame { get; set; } = false;

    public Fox() { }

    public Fox(string name, int age, double height, double weight, bool isAlive, bool isTame)
        : base(name, age, height, weight, isAlive)
    {
        IsTame = isTame;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Ring-ding-ding-ding-dingeringeding!");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} äter en sork.");
    }

    public void Pet()
    {
        var message = IsTame ? $"{Name} viftar med svansen." : $"{Name} biter dig.";
        Console.WriteLine(message);
    }
}
