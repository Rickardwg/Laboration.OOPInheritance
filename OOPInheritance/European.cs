namespace OOPInheritance;

internal class European(string name, int age, double height, double weight, bool isAlive, int lives, bool isIndoor)
    : Cat(name, age, height, weight, isAlive, lives)
{
    public bool IsIndoor { get; set; } = isIndoor;

    public void PrintLifeStyle()
    {
        var message = IsIndoor ? $"{Name} är innekatt." : $"{Name} är utekatt.";
        Console.WriteLine(message);
    }
}
