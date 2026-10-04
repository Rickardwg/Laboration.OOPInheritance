namespace OOPInheritance;

public class European : Cat
{
    public bool IsIndoor { get; set; } = true;

    public European() { }

    public European(string name, int age, double height, double weight, bool isAlive, int lives, bool isIndoor)
        : base(name, age, height, weight, isAlive, lives)
    {
        IsIndoor = isIndoor;
    }

    public void PrintLifeStyle()
    {
        var message = IsIndoor ? $"{Name} är innekatt." : $"{Name} är utekatt.";
        Console.WriteLine(message);
    }
}
