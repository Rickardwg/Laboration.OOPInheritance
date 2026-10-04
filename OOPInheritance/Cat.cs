namespace OOPInheritance;

public class Cat : Animal
{
    public int Lives { get; set; } = 9;

    public Cat() { }

    public Cat(string name, int age, double height, double weight, bool isAlive, int lives)
        : base(name, age, height, weight, isAlive)
    {
        Lives = lives;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Mjau!");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} äter fisk.");
    }

    public void PrintLivesLeft()
    {
        Console.WriteLine($"{Name} har {Lives} kvar.");
    }
}
