using Elearn.Models;
using Microsoft.EntityFrameworkCore;

namespace Elearn.Data
{
    public class AppDbContext: DbContext
    {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }
      
        DbSet<Course> Courses { get; set; }
        DbSet<CourseImage> CourseImages { get; set; }
        DbSet<Author> Authors { get; set; }

    }
}
