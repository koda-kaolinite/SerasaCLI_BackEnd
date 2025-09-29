namespace Tse_Backend.Domain;

public record SchoolUnity
{
    public SchoolUnity(Guid id, string name)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("School unity cannot be null.", nameof(name));

        Id = id;
        Name = name;
    }

    public Guid Id { get; }
    public string Name { get; }

    public static SchoolUnity Create(string name)
    {
        return new SchoolUnity(Guid.NewGuid(), name);
    }

    public static SchoolUnity Create(Guid id, string name)
    {
        return new SchoolUnity(id, name);
    }

    public override string ToString()
    {
        return $"SchoolUnity(Id = {Id:D}, Name = \"{Name}\")";
    }
}