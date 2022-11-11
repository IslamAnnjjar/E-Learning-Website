using BackEnd.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly InstructorService instructorService;

        public InstructorController(InstructorService instructorService)
        {
            this.instructorService = instructorService;
        }


        [HttpGet("/Ins/GetbyID")]

        public IActionResult Get(int id)
        {
            var ins = instructorService.GetService(id);
            return Ok(ins);
        }

        [HttpPost("/Ins/Add")]
        public IActionResult Add(InstructorDTO instructor)
        {
            if (ModelState.IsValid)
            {
                var ins = instructorService.AddService(instructor);
                return Ok(ins);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("/Ins/Update/ID")]
        public IActionResult Update(int id, InstructorDTO instructor)
        {
            if (ModelState.IsValid)
            {
                instructorService.UpdateService(id, instructor);
                return StatusCode(StatusCodes.Status204NoContent, "Current Data Updated");
            }
            return BadRequest("Invalid Data");
        }
    }
}
