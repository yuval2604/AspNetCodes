using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TypeScript.Persistence;

namespace TypeScript.Controllers
{

    [Route("api/cities/{cityId}/[controller]")]
    [ApiController]
    public class PointsOfInterestController: ControllerBase
    {
        public PointsOfInterestController()
        {
        }

        [HttpGet]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataContext.Current.Cities
                .FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{id}")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
            var city = CitiesDataContext.Current.Cities
                .FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }

            // find point of interest
            var pointOfInterest = city.PointsOfInterest
                .FirstOrDefault(c => c.Id == id);

            if (pointOfInterest == null)
            {
                return NotFound();
            }

            return Ok(pointOfInterest);
        }

    }
}
