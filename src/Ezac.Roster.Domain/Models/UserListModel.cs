using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Models
{
    public class UserListModel : BaseListModel
    {
        public IEnumerable<Permission> Permissions { get; set; }
    }
}
