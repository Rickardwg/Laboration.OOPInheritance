namespace OOPInheritance;

public class Cat(string name, int age, double height, double weight, bool isAlive, int lives) 
    : Animal(name, age, height, weight, isAlive)
{
    public int Lives { get; set; } = lives;

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
