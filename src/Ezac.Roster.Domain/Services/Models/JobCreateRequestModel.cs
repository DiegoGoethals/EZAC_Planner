using Ezac.Roster.Domain.Entities;

namespace Ezac.Roster.Domain.Services.Models
{
    public class JobCreateRequestModel
    {
        public string Name { get; set; }
        public string PermissionName { get; set; }
        public double Weight { get; set; }
        public Guid UserId { get; set; }
        public Guid DayPeriodId { get; set; }
        public IEnumerable<Preference> Preferences { get; set; }

    }
}
