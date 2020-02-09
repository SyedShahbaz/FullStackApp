using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BackEnd.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace BackEnd.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DataContext _context;

        public WeatherForecastController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        // This allows us to return HTTP response to the client.
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id) {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }



        // public IEnumerable<WeatherForecast> Get()
        // {
        //     // var rng = new Random();
        //     // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //     // {
        //     //     Date = DateTime.Now.AddDays(index),
        //     //     TemperatureC = rng.Next(-20, 55),
        //     //     Summary = Summaries[rng.Next(Summaries.Length)]
        //     // })
        //     // .ToArray();


        // }
    }
}
