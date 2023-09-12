using API_MySQL.Models;
using Microsoft.EntityFrameworkCore;

namespace API_MySQL.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }

        public DbSet<Estado> Estado { get; set; }
    }
}
