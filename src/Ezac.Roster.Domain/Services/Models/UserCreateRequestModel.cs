using Ezac.Roster.Domain.Entities;

namespace Ezac.Roster.Domain.Services.Models
{
    public class UserCreateRequestModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Scaling { get; set; }
        public bool IsAdmin { get; set; }
        public IEnumerable<Permission> Permissions { get; set; }
        public IEnumerable<Preference> Preferences { get; set; }
        public IEnumerable<Job> Jobs { get; set; }
    }
}
