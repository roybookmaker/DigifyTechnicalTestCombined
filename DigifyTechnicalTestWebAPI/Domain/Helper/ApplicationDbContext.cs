using DigifyWebAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DigifyWebAPI.Domain.Helper
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Registration> Registrations { get; set; }
    }
}
