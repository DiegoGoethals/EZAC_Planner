using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services.Models
{
    public class DayCreateRequestModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Preference> Preferences { get; set; }
        public Guid CalendarId { get; set; }
        public bool IsOpen { get; set; }
        public ICollection<DayPeriod> DayPeriods { get; set; }
    }
}
