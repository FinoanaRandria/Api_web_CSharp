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



        //utilisation de la methode post Pour l'ajout et insertion dans la bd

        [HttpPost]

       public async Task <ActionResult<Course>> CreateCourses(Course course)
        {

            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCourseById), new {id = course.Id} , course);
        }


        //Utilisation de la methode delete 
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteCourse(int id){

            var course = await _context.Courses.FindAsync(id);
            if (course == null) {
                return NotFound();
            }
             _context.Courses.Remove(course);   
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}


