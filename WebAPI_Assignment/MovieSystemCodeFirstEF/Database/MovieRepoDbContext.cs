using Microsoft.EntityFrameworkCore;
using MovieSystemCodeFirstEF.Entities;
namespace MovieSystemCodeFirstEF.Database
{
    public class MovieRepoDbContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MovieDB;Trusted_Connection=True;");
        }

    }
}
