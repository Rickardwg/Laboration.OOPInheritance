using OOPInheritance;

var animals = new List<Animal>()
{
    new Cat("Pisu", 8, 25, 5, true, 9),
    new Dog("Lajka", 3, 65, 6, false, true),
    new Fox("Ylvis", 4, 35, 8, true, false),
    new Transylvanian("Vlad", 2, 30, 3.5, true, 8, "svart"),
    new European("Findus", 6, 30, 4, true, 7, false)
};

foreach  (var animal in animals)
{
    animal.MakeSound();
}