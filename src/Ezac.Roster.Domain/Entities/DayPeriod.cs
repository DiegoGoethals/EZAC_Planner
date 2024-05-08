using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Entities
{
    public class DayPeriod : BaseEntity
    {
        public bool IsOpen { get; set; }
        public DateTime Start {  get; set; }
        public DateTime End { get; set; }
        public Guid DayId { get; set; }
        public Day Day { get; set; }
        public ICollection<Preference> Preferences { get; set; }
        public ICollection<Job>? Jobs {  get; set; } 
    }
}
