using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {

        //  [HttpGet]
        //  public IEnumerable<string> Get()
        ///  {

        ///    return new List<string>() { "C#" , "SQL"};
        //}
        private readonly SchoolApiContext _context;

        public CoursesController(SchoolApiContext context)
        {
            _context = context;
        }

        //ajout de la methode get
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {

            return await _context.Courses.ToListAsync();
        }




    }
}
