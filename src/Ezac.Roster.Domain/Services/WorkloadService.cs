using Ezac.Roster.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services
{
	public class WorkloadService
	{
		private readonly IJobRepository _jobRepository;



		public WorkloadService(IJobRepository jobRepository)
		{
			_jobRepository = jobRepository;


		}
	}
}
