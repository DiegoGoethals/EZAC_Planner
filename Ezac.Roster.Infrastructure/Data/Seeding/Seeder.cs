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


			var users = new User[]
			{
			new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Johnny Debeer", Email = "johnny@ezac.com", Scaling = 1, IsAdmin = false},
			new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Alfonso Rosseel", Email = "Alfie@ezac.com", Scaling = 0.5, IsAdmin = false,},
			new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Mohammed Ali", Email = "Admin@ezac.com", Scaling = 1, IsAdmin = true,},
			new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "Diego Maradonna", Email = "Diego@ezac.com", Scaling = 1, IsAdmin = false,},
			new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Mitch Mitchell", Email = "Mitch@ezac.com", Scaling = 1, IsAdmin = false,},
			new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Mileto Di Marco", Email = "Mileto@ezac.com", Scaling = 1, IsAdmin = false,},
			new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Antoinne De Vlieger", Email = "Antoinne@ezac.com", Scaling = 1, IsAdmin = true,},
			new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "Siegfried Dedeyne", Email = "Siegfried@ezac.com", Scaling = 1, IsAdmin = true,},
			new User { Id = Guid.Parse("00000000-0000-0000-0000-000000000013"), Name = "Dries Deboosere", Email = "Dries@ezac.com", Scaling = 1, IsAdmin = false,},
			};

			var userPermissions = new[]
			{
				new UserPermission { Id = Guid.NewGuid(), UserId = users[0].Id, PermissionId = permissions[0].Id, Experience = 1, Name = permissions[0].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[0].Id, PermissionId = permissions[1].Id, Experience = 5, Name = permissions[1].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[1].Id, PermissionId = permissions[2].Id, Experience = 4, Name = permissions[2].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[1].Id, PermissionId = permissions[3].Id, Experience = 6, Name = permissions[3].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[2].Id, PermissionId = permissions[0].Id, Experience = 8, Name = permissions[0].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[2].Id, PermissionId = permissions[1].Id, Experience = 2, Name = permissions[1].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[2].Id, PermissionId = permissions[2].Id, Experience = 1, Name = permissions[2].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[2].Id, PermissionId = permissions[3].Id, Experience = 9, Name = permissions[3].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[3].Id, PermissionId = permissions[0].Id, Experience = 7, Name = permissions[0].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[3].Id, PermissionId = permissions[3].Id, Experience = 4, Name = permissions[3].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[4].Id, PermissionId = permissions[1].Id, Experience = 3, Name = permissions[1].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[4].Id, PermissionId = permissions[2].Id, Experience = 1, Name = permissions[2].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[5].Id, PermissionId = permissions[1].Id, Experience = 5, Name = permissions[1].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[5].Id, PermissionId = permissions[3].Id, Experience = 4, Name = permissions[3].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[6].Id, PermissionId = permissions[0].Id, Experience = 7, Name = permissions[0].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[6].Id, PermissionId = permissions[2].Id, Experience = 2, Name = permissions[2].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[7].Id, PermissionId = permissions[0].Id, Experience = 3, Name = permissions[0].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[7].Id, PermissionId = permissions[2].Id, Experience = 8, Name = permissions[2].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[7].Id, PermissionId = permissions[3].Id, Experience = 9, Name = permissions[3].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[8].Id, PermissionId = permissions[1].Id, Experience = 4, Name = permissions[1].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[8].Id, PermissionId = permissions[2].Id, Experience = 2, Name = permissions[2].Name },
				new UserPermission { Id = Guid.NewGuid(), UserId = users[8].Id, PermissionId = permissions[3].Id, Experience = 8, Name = permissions[3].Name },

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
			modelBuilder.Entity<User>().HasData(users);
			modelBuilder.Entity<UserPermission>().HasData(userPermissions);
			modelBuilder.Entity<ApplicationCalendar>().HasData(calendar);
			modelBuilder.Entity<Day>().HasData(days);
			modelBuilder.Entity<DayPeriod>().HasData(dayPeriods);
		}
	}
}