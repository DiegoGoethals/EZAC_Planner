using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services.Models
{
	public class PermissionUpdateRequestModel
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public DateTime Updated { get; set; }
		public IEnumerable<User> Users { get; set; }
		public IEnumerable<Job> Jobs { get; set; }
	}
}
