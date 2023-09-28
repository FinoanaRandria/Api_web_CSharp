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

        //ajout de la methode get et recuperation de tout les donnees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {

            return await _context.Courses.ToListAsync();
        }

        //ajout de la methode get   et recuperatino d'un donne specifique by id
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourseById(int id)
        {

            var course = await _context.Courses.Where(c => c.Id.Equals(id)).FirstOrDefaultAsync();
              
            if ( course == null)
            {
                return NotFound();
            }
            return course;

        }



    }
}
