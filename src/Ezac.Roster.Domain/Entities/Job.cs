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
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public Guid? DayPeriodId { get; set; }
        public DayPeriod? DayPeriod { get; set; }
        public ICollection<Preference>? Preferences { get; set; }
        public string PermissionName { get; set; }
        //public Permission Permission { get; set; }
        //public Guid PermissionId { get; set; }
    }
}
