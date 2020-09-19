using Microsoft.AspNetCore.Mvc;

namespace Work.Controllers
{
    public class WorkController : Controller
    {
        [HttpGet("api/user")]
        public IActionResult Get()
        {
            return Ok(new Models.Work{Id=1, Name = "hi"});
        }
    }
}