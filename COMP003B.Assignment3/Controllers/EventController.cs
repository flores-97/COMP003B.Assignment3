﻿
using COMP003B.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers
{
    [Route("register")]
    public class EventController : Controller
    {
        //Get: Register/EventCode
        [HttpGet("/event/register/spring-2025")]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost("Register")]
        public IActionResult Register([FromForm] Register register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            return RedirectToAction("Success", register);
        }

        [Route("success")]
        public IActionResult Success(Register register)
        {
            return View(register);
        }
    }
}
