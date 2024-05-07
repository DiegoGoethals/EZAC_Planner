using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services.Models
{
    public class PreferenceUpdateRequestModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }
        public Guid UserId { get; set; }
        public Guid? DayPeriodId { get; set; }
        public Guid DayId { get; set; }
        public Guid? JobId { get; set; }
    }
}
