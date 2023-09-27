using Microsoft.EntityFrameworkCore;
using Shop.Application.Interfaces;
using Shop.Persistence.EntityTypeConfiguration;
using ShopDomainLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistence
{
    public class BooksDbContext : DbContext, IBooksDbContext
    {
        public DbSet<Book> Books { get; set; }
        public BooksDbContext(DbContextOptions<BooksDbContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookShopConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
