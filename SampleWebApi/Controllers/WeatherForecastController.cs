using Microsoft.AspNetCore.Mvc;

namespace SampleWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")] //[] replaced by class name 
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        [HttpGet("/Harini")]
        public ActionResult<string> Run()
        {
            return BadRequest("WRONG PASSWORD");
        }
        [HttpGet("/Mathu")]
        public ActionResult<string> Get()
        {
            return BadRequest("INVALID REQUEST");
        }

    }
}
