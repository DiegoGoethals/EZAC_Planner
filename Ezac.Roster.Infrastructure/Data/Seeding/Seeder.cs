using Ezac.Roster.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Infrastructure.Data.Seeding
{
	public  class Seeder
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
			modelBuilder.Entity<Day>().HasData(days);

			var dayPeriods = new List<DayPeriod>();
			foreach (var day in days)
			{
				dayPeriods.AddRange(day.DayPeriods);
			}

			static List<Day> GetDays(ApplicationCalendar calendar)
			{
				var days = new List<Day>();
				var startDate = calendar.Start;
				for (int i = 0; i < 14; i++)
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
						new DayPeriod { Id = Guid.NewGuid(), Name = "A", IsOpen = true, Start = DateTime.Today.AddHours(8.5), End = DateTime.Today.AddHours(13), DayId = day.Id },
						new DayPeriod { Id = Guid.NewGuid(), Name = "B", IsOpen = true, Start = DateTime.Today.AddHours(13), End = DateTime.Today.AddHours(17), DayId = day.Id },
						new DayPeriod { Id = Guid.NewGuid(), Name = "C", IsOpen = true, Start = DateTime.Today.AddHours(17), End = DateTime.Today.AddHours(23), DayId = day.Id }
					};
					days.Add(day);
				}

				return days;
			}

			modelBuilder.Entity<Permission>().HasData(permissions);
			modelBuilder.Entity<User>().HasData(users);
			modelBuilder.Entity($"{nameof(Permission)}{nameof(User)}").HasData(permissionUsers);
			modelBuilder.Entity<ApplicationCalendar>().HasData(calendar);
			modelBuilder.Entity<Day>().HasData(days);
			modelBuilder.Entity<DayPeriod>().HasData(dayPeriods);

		}
	}
}
