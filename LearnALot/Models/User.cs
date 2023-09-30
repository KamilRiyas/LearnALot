public class User
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public required string Email { get; set; }

    public int Age { get; set; }

    public Teacher? Teacher { get; set; }

    public Student? Student { get; set; }
}