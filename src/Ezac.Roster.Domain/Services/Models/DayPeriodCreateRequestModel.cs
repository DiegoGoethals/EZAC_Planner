using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services.Models
{
    public class DayPeriodCreateRequestModel
    {
        public string Name { get; set; }
        public bool IsOpen { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Guid DayId { get; set; }
    }
}
