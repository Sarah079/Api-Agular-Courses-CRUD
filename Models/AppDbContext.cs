using Microsoft.EntityFrameworkCore;

namespace Architecture.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base (options) //dbContext is important for code first application 
        { 
        }     

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Course

            modelBuilder.Entity<Course>()
                .HasData(
                new
                {
                    CourseId = 1,
                    Name = "AIM101",
                    Duration = "Semester",
                    Description = "Year 1, Semester 1. Academic Information Management"
                }
            );

            modelBuilder.Entity<Course>()
                .HasData(
                new
                {
                    CourseId = 2,
                    Name = "ALL121",
                    Duration = "Semester",
                    Description = "Year 1, Semester 2. Academic Literacy for IT"
                }
             );
            modelBuilder.Entity<Course>()
                .HasData(
                new
                {
                    CourseId = 3,
                    Name = "INF171",
                    Duration = "Year",
                    Description = "Year 1. Systems Analysis and Design"
                }
            );
            modelBuilder.Entity<Course>()
                .HasData(
                new
                {
                    CourseId = 4,
                    Name = "INF271",
                    Duration = "Year",
                    Description = "Year 2. Systems Analysis and Design"
                }
            );
            modelBuilder.Entity<Course>()
                .HasData(
                new
                {
                    CourseId = 5,
                    Name = "INF272",
                    Duration = "Year",
                    Description = "Year 2. Programming"
                }
            );
            modelBuilder.Entity<Course>()
                .HasData(
                new
                {
                    CourseId = 6,
                    Name = "INF214",
                    Duration = "Semester",
                    Description = "Year 2, Semester 1. Databases"
                }
            );
            modelBuilder.Entity<Course>()
                .HasData(
                new
                {
                    CourseId = 7,
                    Name = "INF315",
                    Duration = "Semester",
                    Description = "Year 3, Semester 1. Programming Management"
                }
            );
            modelBuilder.Entity<Course>()
                .HasData(
                new
                {
                    CourseId = 8,
                    Name = "INF324",
                    Duration = "Semester",
                    Description = "Year 3, Semester 2. IT Trends"
                }
            );
            modelBuilder.Entity<Course>()
                .HasData(
                new
                {
                    CourseId = 9,
                    Name = "INF354",
                    Duration = "Semester",
                    Description = "Year 3, Semester 1. Programming"
                }
            );
            modelBuilder.Entity<Course>()
                .HasData(
                new
                {
                    CourseId = 10,
                    Name = "INF370",
                    Duration = "Year",
                    Description = "Year 3. Project"
                }
            );
        }
    }
}