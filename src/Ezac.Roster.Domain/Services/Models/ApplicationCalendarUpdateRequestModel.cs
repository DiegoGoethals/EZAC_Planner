using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services.Models
{
    public class ApplicationCalendarUpdateRequestModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Updated { get; set; }
        public ICollection<Day> Days { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
