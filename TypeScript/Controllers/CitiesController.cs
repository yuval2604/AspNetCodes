using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TypeScript.Persistence;

namespace TypeScript.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        public CitiesController()
        {
        }

        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataContext.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var city = CitiesDataContext.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (city != null)
            {
                return NotFound();
            }
            return Ok(city);
        }
    }
}
