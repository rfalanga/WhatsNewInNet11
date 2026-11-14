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
        Dog d => $"Dog named {d.Name}",
        Cat c => $"Cat described as {c.Adjective}",
        Bird b => $"Bird of species {b.Species}",
        Shark s => $"Shark with {s.Teeth} teeth",
        _ => "Unknown pet"
    };
    Console.WriteLine(description);
}

public record class Dog(string Name);
public record struct Cat(string Adjective);
public class Bird { public required string Species; }
public record class Shark(int Teeth);
