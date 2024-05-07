using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services.Models
{
    public class JobUpdateRequestModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public Guid UserId { get; set; }
        public Guid DayPeriodId { get; set; }
        public IEnumerable<Preference> Preferences { get; set; }
        public Guid PermissionId { get; set; }
    }
}
