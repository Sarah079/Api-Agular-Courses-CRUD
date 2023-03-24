using Architecture.ViewModel;

namespace Architecture.Models
{
    //middle man for controller and CourseRepository
    public interface ICourseRepository
    {
        // Course
        Task<Course[]> GetAllCourseAsync(); //get all

        Task<CourseViewModel> GetCourse(int CourseId); //get one 

        Task<int> AddCourse(CourseViewModel course);

        Task<int> EditCourse(CourseViewModel course, int CourseId);

        Task<int> DeleteCourse(CourseViewModel course);

    }
}
