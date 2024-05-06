﻿using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Infrastructure.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Infrastructure.Repositories
{
	public class JobRepository : BaseRepository<Job>, IJobRepository
	{
		public JobRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<Job>> logger)
			: base(applicationDbContext, logger)
		{
		}
	}
}