using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EFCoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //List<TestModel> list = new List<TestModel>();
            //foreach (var a in Enumerable.Range(1, 500))
            //{
            //    list.Add(new TestModel
            //    {
            //        Name = "Mohan" + Guid.NewGuid()
            //    }) ;
            //}

            //using var context = new ShopperStopDbContext();
            //context.Test.AddRange(list);
            //var outp = context.SaveChanges();

            //var res = context.Test.Select(x=>x);
            //return Ok(res);



            return null;
        }
    }
}
