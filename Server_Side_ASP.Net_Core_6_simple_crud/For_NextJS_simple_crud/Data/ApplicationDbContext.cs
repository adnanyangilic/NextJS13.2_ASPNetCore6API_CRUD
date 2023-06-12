using For_NextJS_simple_crud.Models;
using Microsoft.EntityFrameworkCore;

namespace For_NextJS_simple_crud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }




        public virtual DbSet<Product> Products { get; set; }




    }
}
