using OOPInheritance;
//x handle zoo animals
//x Animal base
//x 5 shared properties
//x 3 shared methods

//x 3 inherited animals
//x 1 new propert and method
// default values for properties. both in class and base class
//x all must have MakeSound
//x constructor for creating new animals

// one animal split into two subclasses
// dog -> bulldog, chihuahua
// new property and method or overload to be unique

// main initialize several animals and make sound

//extra
// human is animal
// mammal and reptile
// wild and tame
// plants

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