using System;
using Microsoft.AspNetCore.Mvc;

namespace Swagger.Controllers
{
    public class TestController: Controller
    {
        [HttpGet("api/user")]
        public IActionResult Get()
        {
            return Ok(new {name="yuval" });
        }
    }
}
