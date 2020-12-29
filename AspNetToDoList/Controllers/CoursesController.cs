using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetToDoList.Entities;
using AspNetToDoList.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        
        private readonly CourseService _courseService;
        public CoursesController( CourseService cService)
        {
            _courseService = cService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetAll()
        {
            var courses = await _courseService.GetAllAsync();
            return Ok(courses);
        }

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Course>> GetById(string id)
        {
            var course = await _courseService.GetByIdAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);
            
        }
        [HttpPost]
        public async Task<IActionResult> Create(Course course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _courseService.CreateAsync(course);
            return Ok(course);
        }
        [HttpPut]
        public async Task<IActionResult> Update(string id, Course updatedCourse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var queriedStudent = await _courseService.GetByIdAsync(id);
            if (queriedStudent == null)
            {
                return NotFound();
            }
            await _courseService.UpdateAsync(id, updatedCourse);
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var student = await _courseService.GetByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            await _courseService.DeleteAsync(id);
            return NoContent();
        }
    }
}
