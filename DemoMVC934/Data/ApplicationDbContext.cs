using Microsoft.EntityFrameworkCore;
using DemoMVC934.Models;

namespace DemoMVC934.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
