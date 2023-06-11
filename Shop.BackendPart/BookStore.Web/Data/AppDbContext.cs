using BookStore.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Web.Data
{
    //this is our database !
    public class AppDbContext : DbContext
    {
        //private readonly DbContextOptions _options;
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
