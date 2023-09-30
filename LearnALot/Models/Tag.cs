public class Tag
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public ICollection<Course>? Courses { get; set; }
}