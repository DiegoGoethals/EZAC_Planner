using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Entities
{
    public class Day : BaseEntity
    {
        public DateTime Date {  get; set; }
        public ICollection<Preference> Preferences { get; set; }
        public Calendar Calendar { get; set; }
        public Guid CalanderId { get; set; }
        public bool IsOpen { get; set; }
    }
}
