namespace Architecture.Models
{
    public interface ICourseRepository
    {
        // Course
        Task<Course[]> GetAllCourseAsync();

    }
}
