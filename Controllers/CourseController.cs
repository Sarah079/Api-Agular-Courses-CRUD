using Architecture.Models;
using Architecture.ViewModel;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

//checking whether course data has been passed and whether the api is successful
namespace Architecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        //GET - (read) given 
        [HttpGet]
        [Route("GetAllCourses")]
        public async Task<IActionResult> GetAllCourses() //async
        {
            try
            {
                var results = await _courseRepository.GetAllCourseAsync(); // await 
                return Ok(results);
            }
            catch (Exception)
            {
                return StatusCode(500,"Internal Server Error. Please contact support.");
            }
        }

        //POST - (add)
        //1. if result code == success (200) "added"
        //2. else msg and catch err msg
        [HttpPost]
        [Route("AddCourse")]
        public async Task<IActionResult> AddCourse(CourseViewModel course) //(pass data)
        {
            try
            {
                var results = await _courseRepository.AddCourse(course);
                if(results == 200)
                {
                    return Ok("Added " + course.Name + "for " + course.Duration);
                    
                }
                else
                {
                    return BadRequest("Course not added. Please retry");
                }
                
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support.");
            }
        }

        //PUT - (edit)
        //1. get course to edit
        //2. put edited course 
        [HttpGet]
        [Route("GetCourse/{id}")]
        public async Task<IActionResult> GetCourse(int CourseId)
        {
            try
            {
                var results = await _courseRepository.GetCourse(CourseId);
                
                if (results.LocationId == 200)
                {
                    return Ok(results);
                }
                else
                {
                    return BadRequest("Course not found. Please retry");
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support.");
            }
        }
        [HttpPut]
        [Route("EditCourse/{id}")]
        public async Task<IActionResult> EditCourse( CourseViewModel course, int CourseId)
        {
            try
            {
                var results = await _courseRepository.EditCourse(course, CourseId);
                if (results == 200)
                {
                    return Ok(course.Name + "Updated" );                    
                }
                else
                {
                    return BadRequest("Course not updated. Please retry");
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support.");
            }
        }

        //DELETE - (delete)
        [HttpDelete]
        [Route("DeleteCourse")]
        public async Task<IActionResult> DeleteCourse(CourseViewModel course)
        {
            try
            {
                
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support.");
            }
        }
    }
}
