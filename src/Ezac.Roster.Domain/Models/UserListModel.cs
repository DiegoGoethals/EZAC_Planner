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
        public double Scaling { get; set; }
        public IEnumerable<UserPermission> Permissions { get; set; }
        public IEnumerable<Preference> Preferences { get; set; }
    }
}
