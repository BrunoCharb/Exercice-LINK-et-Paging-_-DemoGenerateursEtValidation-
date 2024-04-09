using Microsoft.EntityFrameworkCore;

namespace DemoGenerateursEtValidation.Models
{
    public class AutoDbContext : DbContext
    {

        public AutoDbContext(DbContextOptions<AutoDbContext> options) : base(options) { }

        public DbSet<Auto> Autos { get; set; }
    }
}
