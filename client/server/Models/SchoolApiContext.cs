using Microsoft.EntityFrameworkCore;

namespace server.Models
{
    public class SchoolApiContext : DbContext


    {

        public SchoolApiContext(DbContextOptions<SchoolApiContext> options)
            :base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }

    }
}
