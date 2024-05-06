using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Entities
{
    public class Preference : BaseEntity
    {
        public bool Available { get; set; }
        //public User User { get; set; }
        public Guid UserId { get; set; }
        public Guid? DayPeriodId { get; set; }
        //public DayPeriod DayPeriod { get; set; }
        //public Day Day { get; set; }
        public Guid DayId { get; set; }

        //public Job Job{ get; set; }
        public Guid? JobId { get; set; }
    }
}
