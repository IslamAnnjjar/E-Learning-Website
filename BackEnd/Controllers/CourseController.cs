using BackEnd.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly CourseService courseService;
        private readonly ProjectContext projectContext;

        public CourseController(CourseService courseService, ProjectContext projectContext)
        {
            this.courseService = courseService;
            this.projectContext = projectContext;
        }


        [HttpGet]
        [Route("/Course/Get")]
        public IActionResult Get()
        {
            var course = courseService.GetService();
                return Ok(course);
        }

        [HttpGet("/Course/Get/{name:alpha}")]
        public IActionResult SelectCourseByName(string name)
        {
            var crs = courseService.SelectByNameService(name);
            if (crs == null)
                return BadRequest("Name Not Found");
            return Ok(crs);
        }

        [HttpPost("/Course/Add")]
        public IActionResult Add(CourseWithVideoInstructorUserDTO courses)
        {
            if (ModelState.IsValid)
            {
                var crs = courseService.AddService(courses);
                //string url = Url.Link("SelectEmployeesByIDRoute", new { id = courses.CrsID });
                return Ok(crs);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("/Course/Update/ID")]
        public IActionResult Update([FromRoute] int id, [FromBody] CourseWithVideoInstructorUserDTO NewCourse)
        {
            if (ModelState.IsValid)
            {
                courseService.UpdateService(id, NewCourse);
                return StatusCode(StatusCodes.Status204NoContent, "Current Data Updated");
            }
            return BadRequest("Invalid Data");
        }

        [HttpDelete("/Course/Delete/ID")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                courseService.DeleteService(id);
                return StatusCode(StatusCodes.Status204NoContent, "Course Deleted Successfully");
            }
            return BadRequest("No Data To Be Deleted");
        }
    }
}
