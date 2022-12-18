using Microsoft.EntityFrameworkCore;
using MVCCRUDDemo.Models.Domain;

namespace MVCCRUDDemo.DBContext
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions<MVCDbContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Friend> Friends { get; set; }
    }
}
