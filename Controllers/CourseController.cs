using Architecture.Models;
using Architecture.ViewModel;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

//create 
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

        //-------------------------------------------------------GET - (read) --------------------------------------------------
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

        //-----------------------------------------------------POST - (add)-----------------------------------------------------
        [HttpPost]
        [Route("AddCourse")]
        public async Task<IActionResult> AddCourse() 
        {
            try
            {

            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support.");
            }
        }

        //-----------------------------------------------------PUT - (edit) ----------------------------------------------------
        [HttpPut]
        [Route("EditCourse")]
        public async Task<IActionResult> EditCourse()
        {
            try
            {
                
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support.");
            }
        }

        //-----------------------------------------------------DELETE - (delete)------------------------------------------------
        [HttpDelete]
        [Route("DeleteCourse")]
        public async Task<IActionResult> DeleteCourse()
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
