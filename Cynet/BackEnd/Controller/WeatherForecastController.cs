using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controller;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    public WeatherForecastController()
    {

    }

    [HttpGet()]
    public void Get()
    {

    }

}
