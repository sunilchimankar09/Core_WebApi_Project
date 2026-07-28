using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult studentInfo()
        {
            return Ok ("Hello");
        }

        [HttpGet("personInfo")]
        public IActionResult personInfo()
        {
            return Ok("Sunil Narayan Chimankar");
        }
    }
}
