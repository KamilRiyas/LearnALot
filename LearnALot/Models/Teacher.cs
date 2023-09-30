public class Teacher
{
    public Guid Id { get; set; }

    public string? Handle { get; set; }

    public ICollection<Course>? Courses { get; set; }
}