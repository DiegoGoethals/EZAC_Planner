using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Entities
{
	public class Permission : BaseEntity
	{
		public ICollection<UserPermission> UserPermissions { get; set; }
	}
}
