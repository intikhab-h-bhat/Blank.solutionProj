using Blank.solutionProj.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace Blank.solutionProj.DataBase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            

        }

        public DbSet<Book> Books { get; set; }
    }
}
