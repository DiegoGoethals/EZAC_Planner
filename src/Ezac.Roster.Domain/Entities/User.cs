using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Entities
{
    public class User
    {
        public string Email { get; set; }
        public double Scaling { get; set; }
        public bool IsAdmin { get; set; }
        //public ICollection<Permission> Permissions { get; set; }
        //public ICollection<Preference> Preferences { get; set; }
    }
}
