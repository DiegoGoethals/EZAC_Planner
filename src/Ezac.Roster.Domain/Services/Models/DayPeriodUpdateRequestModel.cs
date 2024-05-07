using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services.Models
{
    public class DayPeriodUpdateRequestModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsOpen { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime Updated { get; set; }
    }
}
