using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Infrastructure.Data.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Ezac.Roster.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ApplicationCalendar> Calendars { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<DayPeriod> DayPeriods { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationCalendar>()
                .HasMany(calendar => calendar.Days)
                .WithOne(day => day.Calendar)
                .HasForeignKey(day => day.CalendarId);

            modelBuilder.Entity<ApplicationCalendar>()
                .HasMany(calendar => calendar.Users)
				.WithMany(user => user.ApplicationCalendars);

            modelBuilder.Entity<Day>()
                .HasMany(day => day.Preferences)
                .WithOne(preference => preference.Day)
                .HasForeignKey(preference => preference.DayId);

            modelBuilder.Entity<Day>()
                .HasMany(day => day.DayPeriods)
                .WithOne(period => period.Day)
                .HasForeignKey(period =>  period.DayId);

            modelBuilder.Entity<DayPeriod>()
                .HasMany(period => period.Preferences)
                .WithOne(preference => preference.DayPeriod)
                .HasForeignKey(preference => preference.DayPeriodId);

            modelBuilder.Entity<DayPeriod>()
                .HasMany(period => period.Jobs)
                .WithOne(job => job.DayPeriod)
                .HasForeignKey(job => job.DayPeriodId);

            modelBuilder.Entity<Job>()
                .HasOne(job => job.User)
                .WithMany(user => user.Jobs)
                .HasForeignKey(job => job.UserId);

            modelBuilder.Entity<Job>()
                .HasMany(job => job.Preferences)
                .WithOne(preference => preference.Job)
                .HasForeignKey(preference => preference.JobId);

            modelBuilder.Entity<Preference>()
                .HasOne(preference => preference.User)
                .WithMany(user => user.Preferences)
                .HasForeignKey(preference => preference.UserId);

            modelBuilder.Entity<UserPermission>()
                .HasOne(up => up.User)
                .WithMany(user => user.UserPermissions)
                .HasForeignKey(up => up.UserId);

            modelBuilder.Entity<UserPermission>()
                .HasOne(up => up.Permission)
                .WithMany(permission => permission.UserPermissions)
                .HasForeignKey(up => up.PermissionId);

            Seeder.Seed(modelBuilder);
        }
    }
}
