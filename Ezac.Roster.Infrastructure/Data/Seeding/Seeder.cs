using Ezac.Roster.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Infrastructure.Data.Seeding
{
	public class Seeder
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			var permissions = new Permission[]
			{
			new Permission { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Lierist"},
			new Permission { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Startofficier" },
			new Permission { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Bardienst" },
			new Permission { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Instructeur" }
			};

			var jobs = new Job[]
			{
				new Job { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Lierist", PermissionName ="Lierist"},
				new Job { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Startofficier",PermissionName ="Startofficier" },
				new Job { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Bardienst", PermissionName ="Bardienst"},
				new Job { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Instructeur", PermissionName ="Instructeur"},
				new Job { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "Instructeur(DDI)", PermissionName ="Instructeur"},
			};


			var users = new User[]
			{
			new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Johnny Debeer", Email = "johnny@ezac.com", Scaling = 1, IsAdmin = false},
			new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Alfonso Rosseel", Email = "Alfie@ezac.com", Scaling = 0.5, IsAdmin = false,},
			new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Mohammed Ali", Email = "Admin@ezac.com", Scaling = 1, IsAdmin = true,}
			};



			var permissionUsers = new[]
			{
			new { Id = Guid.NewGuid(), UsersId = users[0].Id, PermissionsId = permissions[0].Id },
			new { Id = Guid.NewGuid(), UsersId = users[0].Id, PermissionsId = permissions[1].Id },
			new { Id = Guid.NewGuid(), UsersId = users[1].Id, PermissionsId = permissions[2].Id },
			new { Id = Guid.NewGuid(), UsersId = users[1].Id, PermissionsId = permissions[3].Id },
			new { Id = Guid.NewGuid(), UsersId = users[2].Id, PermissionsId = permissions[0].Id },
			new { Id = Guid.NewGuid(), UsersId = users[2].Id, PermissionsId = permissions[1].Id },
			new { Id = Guid.NewGuid(), UsersId = users[2].Id, PermissionsId = permissions[2].Id },
			new { Id = Guid.NewGuid(), UsersId = users[2].Id, PermissionsId = permissions[3].Id }
			};

			var calendar = new ApplicationCalendar
			{ Id = Guid.NewGuid(), Name = "Zweefvliegkalender", Start = DateTime.Now, End = DateTime.Now.AddMonths(6), };

			var days = GetDays(calendar);

			var dayPeriods = new List<DayPeriod>();
			foreach (var day in days)
			{
				foreach (var period in day.DayPeriods)
				{
					period.DayId = day.Id;
					dayPeriods.Add(period);
				}
				day.DayPeriods = null;
			}

			static List<Day> GetDays(ApplicationCalendar calendar)
			{
				var days = new List<Day>();
				var startDate = calendar.Start;
				for (int i = -1; i < 14; i++)
				{
					var currentDate = startDate.AddDays(i);
					var day = new Day
					{
						Id = Guid.NewGuid(),
						Date = currentDate,
						Name = currentDate.DayOfWeek.ToString(),
						CalendarId = calendar.Id,
						IsOpen = currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday
					};

					day.DayPeriods = new List<DayPeriod>

				{
					new DayPeriod { Id = Guid.NewGuid(), Name = "A", IsOpen = true, Start = currentDate.AddHours(8.5), End = currentDate.AddHours(13), },
						new DayPeriod { Id = Guid.NewGuid(), Name = "B", IsOpen = true, Start = currentDate.AddHours(13), End = currentDate.AddHours(17), },
						new DayPeriod { Id = Guid.NewGuid(), Name = "C", IsOpen = true, Start = currentDate.AddHours(17), End = currentDate.AddHours(23), },
				};
					days.Add(day);
				}

				return days;
			}

			modelBuilder.Entity<Permission>().HasData(permissions);
			modelBuilder.Entity<Job>().HasData(jobs);
			modelBuilder.Entity<User>().HasData(users);
			modelBuilder.Entity($"{nameof(Permission)}{nameof(User)}").HasData(permissionUsers);
			modelBuilder.Entity<ApplicationCalendar>().HasData(calendar);
			modelBuilder.Entity<Day>().HasData(days);
			modelBuilder.Entity<DayPeriod>().HasData(dayPeriods);
		}
	}
}