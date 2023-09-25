using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {

             return new List<string>() { "C#" , "SQL"};
        }


    }
}
