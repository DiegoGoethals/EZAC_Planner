using Ezac.Roster.Domain.Entities;

namespace Ezac.Roster.Web.Models
{
	public class MemberViewModel
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public double Scaling { get; set; }
		public bool IsAdmin { get; set; }
		public ICollection<UserPermission> UserPermissions { get; set; }
		public ICollection<Preference> Preferences { get; set; }
		public ICollection<Job> Jobs { get; set; }
	}
}
