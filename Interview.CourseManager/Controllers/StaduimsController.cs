using Interview.CourseManager.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Interview.CourseManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaduimsController : ControllerBase
    {
        IStuduimService StuduimService;
        
        public StaduimsController(IStuduimService _StuduimService)
        {
            StuduimService = _StuduimService;

        }
        [HttpGet]
        public ActionResult GetAllStaduim()
        {
            var data = StuduimService.getStaduims();
            return Ok(data);

        }
    }
}
