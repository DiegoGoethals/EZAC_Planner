﻿using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Interfaces.Repositories
{
    public interface IJobRepository : IBaseRepository<Job>
    {
		public Task<List<Job>> GetJobsByCalendarIdAsync(Guid calendarId);

	}
}
