using Interview.CourseManager.Dtos;
using Interview.CourseManager.efCoreCode;
using Interview.CourseManager.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Interview.CourseManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService CourseService;
        public CoursesController(ICourseService courseService )
        {
            CourseService = courseService;
        }
        [HttpPost]
        public ActionResult AddCourse(AddCourseDto model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    Response<List<CourseReservationDto>> response = CourseService.CreateCourse(model);
                    if (response.status == false)
                        return Ok(response);
                    return Ok(response);
                }
                return BadRequest(new { errors = ModelState.Select(m => m.Value.Errors.Select(e => e.ErrorMessage)).Where(p => p.Any()) });

            }
            catch (Exception e) {
                ModelState.AddModelError(string.Empty, $"{e}");
                return BadRequest(new { errors = ModelState.Select(m => m.Value.Errors.Select(e => e.ErrorMessage)).Where(p => p.Any()) });
            }
        }
    }
}
