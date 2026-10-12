Duck duck = new Duck { Name = "Donald" };
Console.WriteLine(duck.Quack()); // Output: Donald quacks!

public class Duck
{
    public required string Name { get; init; }

    public string Quack() => $"{Name} quacks!";
}
