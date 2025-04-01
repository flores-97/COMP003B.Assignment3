using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment3.Models;

namespace COMP003B.Assignment3.Controllers
{
    [Route("register")]
    public class EventController : Controller
    {
        //Get: Register/EventCode
        [HttpGet("/event/register/spring-2025")]
        [HttpGet("/event/register/fall-2025")]
        [HttpGet("/Event/Register")]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost("Event/Register")]
        public IActionResult Register([FromForm] Register register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            return RedirectToAction("Event/Success", register);
        }

        [Route("Event/Success")]
        [HttpGet("Event/Success")]
        public IActionResult Success(Register register)
        {
            return View(register);
        }
    }
}
