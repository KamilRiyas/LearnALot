using Microsoft.EntityFrameworkCore;

public class LearnDBContext : DbContext
{
    public LearnDBContext(DbContextOptions options):base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Teacher> Teachers { get; set; }

    public DbSet<Student> Students { get; set; }

    public DbSet<Course> Courses { get; set; }

    public DbSet<Enrollment> Enrollments { get; set; }

    public DbSet<Chapter> Chapters { get; set; }

    public DbSet<Tag> Tags { get; set; }
}