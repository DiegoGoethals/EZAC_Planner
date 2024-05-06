using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Entities
{
    public class Job : BaseEntity
    {
        public double Weight { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<DayPeriod> Dayperiods { get; set; }
        public ICollection<Preference> Preferences { get; set; }
        public Permission Permission { get; set; }
        public Guid PermissionId { get; set; }
    }
}
