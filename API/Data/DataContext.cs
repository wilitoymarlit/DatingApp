using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //Clase de DataContext heredara de DbContext
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set;}
    }
}