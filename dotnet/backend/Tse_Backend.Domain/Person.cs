namespace Tse_Backend.Domain;

public record Person
{
    public Person(Guid id, string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("The person's name cannot be null.", nameof(name));

        Id = id;
        Name = name;
    }

    public Guid Id { get; }
    public string Name { get; }

    public static Person Create(string name)
    {
        return new Person(Guid.NewGuid(), name);
    }

    public static Person Create(Guid id, string name)
    {
        return new Person(id, name);
    }

    public override string ToString()
    {
        return $"Person(Id = {Id:D}, Name = \"{Name}\")";
    }
}
