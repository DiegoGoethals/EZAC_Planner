using Ezac.Roster.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ezac.Roster.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Day> Days { get; set; }
        public DbSet<DayPeriod> DayPeriods { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
