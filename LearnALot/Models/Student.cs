public class Student
{
    public Guid Id { get; set; }

    public string? Handle { get; set; }

    public ICollection<Enrollment>? Courses { get; set; }
}