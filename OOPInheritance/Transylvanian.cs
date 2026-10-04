namespace OOPInheritance;

public class Transylvanian : Cat
{
    public string Carpati { get; set; } = "svart";

    public Transylvanian() { }

    public Transylvanian(string name, int age, double height, double weight, bool isAlive, int lives, string carpati)
        : base(name, age, height, weight, isAlive, lives)
    {
        Carpati = carpati;
    }

    public void PrintCarpati()
    {
        Console.WriteLine($"{Name} är {Carpati}.");
    }
}
