using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services.Models
{
    public class ApplicationCalendarCreateRequestModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public IEnumerable<Day> Days { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
