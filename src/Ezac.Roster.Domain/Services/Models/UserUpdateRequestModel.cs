using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services.Models
{
    public class UserUpdateRequestModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Scaling { get; set; }
        public bool IsAdmin { get; set; }
        public IEnumerable<UserPermission> Permissions { get; set; }
        public IEnumerable<Preference> Preferences { get; set; }
        public IEnumerable<Job> Jobs { get; set; }
    }
}
