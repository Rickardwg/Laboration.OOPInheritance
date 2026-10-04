namespace OOPInheritance;

public class Transylvanian(string name, int age, double height, double weight, bool isAlive, int lives, string carpati)
    : Cat(name, age, height, weight, isAlive, lives)
{
    public string Carpati { get; set; } = carpati;

    public void PrintCarpati()
    {
        Console.WriteLine($"{Name} är {Carpati}.");
    }
}
