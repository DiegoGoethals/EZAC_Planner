using Ezac.Roster.Domain.Entities;

namespace Ezac.Roster.Web.Models
{
    public class CalenderViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<Day> Days { get; set; }
    }
}
