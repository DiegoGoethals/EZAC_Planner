﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Entities
{
    public class ApplicationCalendar : BaseEntity
    {
        public ICollection<Day> Days { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
