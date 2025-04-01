using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment3.Models;

namespace COMP003B.Assignment3.Controllers
{
    [Route("register")]
    public class EventController : Controller
    {
        //Get: Register/EventCode
        [HttpGet("eventcode")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register([FromForm] EventRegistration register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            return RedirectToAction("Success", register);
        }

        [Route("success")]
        public IActionResult Success(EventRegistration register)
        {
            return View(register);
        }
    }
}
