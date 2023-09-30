public class Course
{
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public ICollection<Course>? Chapters { get; set; }

    public ICollection<Enrollment>? Enrollments { get; set; }

    public ICollection<Tag>? Tags { get; set; }
}