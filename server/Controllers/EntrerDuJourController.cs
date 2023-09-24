using Microsoft.AspNetCore.Mvc;

namespace server.Controllers;

[ApiController]
//route de notre api
[Route("api/[controller]")]
public class EntrerDuJourController : ControllerBase
{
   

    [HttpGet(Name = "GetWeatherForecast")]

    //modele de donnee
    public IEnumerable<EntrerDuJour> Get()
    {
        
    }
}
