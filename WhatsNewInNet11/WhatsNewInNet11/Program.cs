List<Pet> pets = [
    new Dog("Fido"),
    new Cat("Fluffy"),
    new Bird { Species = "Parrot" }
];

foreach (var pet in pets)
{
    Console.WriteLine(pet.Description);
}

// Adding a union

union Pet(Dog, Cat?, Bird)  //these arguments are called case types, and they are the types that make up the union. The union type is called Pet, and it can be either a Dog, a Cat, or a Bird.
{
    public string Description => this switch
    {
        Dog dog => dog.Name,
        Cat(var adjective) => $"A {adjective} cat",
        Bird { Species: var species } => $"A {species}",
        null => "😾"
    };
}


public record class Dog(string Name);
public record struct Cat(string Adjective);
public class Bird { public required string Species; }
public record class Shark(int Teeth);
