namespace Tse_Backend.Domain;

public class User
{
    public Guid Id { get; }
    public Person Person { get; }
    public string Email { get; }
    public string Password { get; }

    private User(Guid id, Person person, string email, string password)
    {
        this.Id = id;
        this.Person = person;
        this.Email = email;
        this.Password = password;
    }

    public static User Create(Guid id, Person person, string email, string password)
    {
        return new User(id, person, email, password);
    }

    public static User Create(Person person, string email, string password)
    {
        return new User(Guid.NewGuid(), person, email, password);
    }

    public override string ToString()
    {
        return $"Registration [{Id:D}] | Person [{this.Person}] | Email [{this.Email} | Password [{this.Password}]]";
    }
}
