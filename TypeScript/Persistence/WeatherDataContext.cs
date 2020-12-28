using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;

namespace TypeScript.Persistence
{

    public class WeatherDataContext
    {
        public static WeatherDataContext Current { get; } = new WeatherDataContext();
        public List<WeatherForecast> Forcast { get; set; }
        public WeatherDataContext()
        {
            Forcast =  ReturnForcast() ;
            
        }

        public List<WeatherForecast> ReturnForcast()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToList();
        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

    }
}
