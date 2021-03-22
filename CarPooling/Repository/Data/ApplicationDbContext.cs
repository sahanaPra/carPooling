using Contract.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<UserVehicle> UserVehicle { get; set; }
        public DbSet<UserVehicleRide> UserVehicleRide { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }        
    }
}
