using Project.Models;
using Microsoft.EntityFrameworkCore;
namespace Project.Data{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) :base(options)
        {

        }   
        public DbSet<Platform> Platforms { get; set; }     
    }
}