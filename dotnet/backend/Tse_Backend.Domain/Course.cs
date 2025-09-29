namespace Tse_Backend.Domain;

public record Course
{
    private Course(Guid id, string name, ushort workLoad)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("The course name cannot be null or empty.", nameof(name));

        Id = id;
        Name = name;
        WorkLoad = workLoad;
    }

    public Guid Id { get; }

    public string Name { get; }
    public ushort WorkLoad { get; }

    public static Course Create(string name, ushort workLoad)
    {
        return new Course(Guid.NewGuid(), name, workLoad);
    }

    public static Course Create(Guid id, string name, ushort workLoad)
    {
        return new Course(id, name, workLoad);
    }

    public override string ToString()
    {
        return $"Course: (\"{Name}\" ID: {Id:D}, Workload: {WorkLoad}h)";
    }
}