using Architecture.ViewModel;
using Microsoft.EntityFrameworkCore;

//calling the data to be passed through controller 
namespace Architecture.Models
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _appDbContext; //initialises appdbcontext 

        public CourseRepository(AppDbContext appDbContext)
        {
                _appDbContext = appDbContext;
        }
        public async Task<Course[]> GetAllCourseAsync()
        {
            IQueryable<Course> query = _appDbContext.Courses;
            return await query.ToArrayAsync();
        }
        public async Task<int> AddCourse(CourseViewModel course)
        {
            IQueryable<Course> query = _appDbContext.Courses;
            return await query.ToArrayAsync();
        }
        public async Task<int> EditCourse(CourseViewModel course, int CourseId)
        {
            IQueryable<Course> query = _appDbContext.Courses;
            return await query.ToArrayAsync();
        }
        public async Task<int> DeleteCourse(CourseViewModel course)
        {
            IQueryable<Course> query = _appDbContext.Courses;
            return await query.ToArrayAsync();
        }
    }
}
