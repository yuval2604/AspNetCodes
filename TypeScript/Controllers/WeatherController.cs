using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using TypeScript.Persistence;

namespace TypeScript.Controllers
{
    [Route("api/Weather")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private WeatherController _context;

        public WeatherController(WeatherController context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(WeatherDataContext.Current.Forcast);
        }
    }
}
