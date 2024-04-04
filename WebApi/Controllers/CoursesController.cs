using Business.DTOs;
using Business.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(CourseService courseService) : ControllerBase
    {
        private readonly CourseService _courseService = courseService;

        [HttpPost]
        public async Task<IActionResult> AddCourse(CourseDTO dto)
        {
            if (dto is not null)
            { 
                await _courseService.CreateNewCourseAsync(dto);
                return CreatedAtAction(nameof(AddCourse), dto);
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetCoursesAsync()
        {
            try
            {
                var courses = await _courseService.GetAllCoursesAsync();

                if (courses is not null)
                {
                    return Ok(courses);
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return StatusCode(500, "An error occurred while retrieving courses.");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCourseAsync(string id)
        {
            try
            {
                var isRemoved = await _courseService.RemoveCourseAsync(id);

                if (isRemoved)
                {
                    return Ok("Course deleted successfully");
                }
                else
                {
                    return NotFound("Course not found or could not be deleted");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return StatusCode(500, "An error occurred while deleting the course");
            }
        }
    }
}
