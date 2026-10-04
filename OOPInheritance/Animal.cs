namespace OOPInheritance;

public abstract class Animal
{
    public string Name { get; set; } = "Okänt";
    public int Age { get; set; } = 0;
    public double Height { get; set; } = 0;
    public double Weight { get; set; } = 0;
    public bool IsAlive { get; set; } = false;

    public Animal() { }

    public Animal(string name, int age, double height, double weight, bool isAlive)
    {
        Name = name;
        Age = age;
        Height = height;
        Weight = weight;
        IsAlive = isAlive;
    }

    public abstract void MakeSound();

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} äter.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} sover.");
    } 
}
