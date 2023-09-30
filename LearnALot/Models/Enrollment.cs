public class Enrollment
{
    public Guid Id { get; set; }

    public required Student Student { get; set; }

    public required Course Course { get; set; }

    public bool Status { get; set; }
}