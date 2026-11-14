List<object> pets = [
    new Dog("Fido"),
    new Cat("Fluffy"),
    new Bird { Species = "Parrot" },
    new Shark(300)
];

foreach (var pet in pets)
{
    var description = pet switch
    {
        Dog dog => dog.Name,
        Cat(var adjective) => $"A {adjective} cat",
        Bird { Species: var species } => $"A {species}",
        Shark(var teeth) => $"{new('A', teeth)} shark!",
        _ => "Unknown pet"  // This line was not in the demo code, GitHub Copilot added it 
    };
    Console.WriteLine(description);
}

public record class Dog(string Name);
public record struct Cat(string Adjective);
public class Bird { public required string Species; }
public record class Shark(int Teeth);
