using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services.Models
{
	public class PermissionCreateRequestModel
	{
		public string Name { get; set; }
		public DateTime Created { get; set; }
		public IEnumerable<User> Users { get; set; }
		public IEnumerable<Job> Jobs { get; set; }
	}
}
