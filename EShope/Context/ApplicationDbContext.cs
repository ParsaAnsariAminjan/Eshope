using EShope.Entities.Account;
using EShope.Entities.Blog;
using EShope.Entities.Catalog;
using Microsoft.EntityFrameworkCore;

namespace EShope.Contex
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       // Public DbSet<DbSet Class Name>  Table Name In Database 
        public DbSet<Banner> Banners { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<User>  Users { get; set; }
    }

}
