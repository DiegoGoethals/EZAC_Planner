using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public double Scaling { get; set; }
        public bool IsAdmin { get; set; }
        public ICollection<Preference> Preferences { get; set; }
        public ICollection<Job>? Jobs { get; set; }
        public ICollection<UserPermission> UserPermissions { get; set; }
        public ICollection<ApplicationCalendar> ApplicationCalendars { get; set; }
    }
}
