namespace Tse_Backend.Domain;

public record Student(Guid Id, Person Person, Course? Course, SchoolUnity? SchoolUnity)
{
    public Person Person { get; } = Person ?? throw new ArgumentNullException(nameof(Person));

    public static Student Create(Person person, Course? course, SchoolUnity? schoolUnity)
    {
        return new Student(Guid.NewGuid(), person, course, schoolUnity);
    }

    public static Student Create(Guid id, Person person, Course? course, SchoolUnity? schoolUnity)
    {
        return new Student(id, person, course, schoolUnity);
    }

    public override string ToString()
    {
        return $"Registration [{Id:D}] | Student: {Person} | Course: {Course} | Unity: {SchoolUnity}";
    }
}