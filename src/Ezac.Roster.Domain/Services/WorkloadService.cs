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
		private readonly IUserRepository _userRepository;


		public WorkloadService(IJobRepository jobRepository, IUserRepository userRepository)
		{
			_jobRepository = jobRepository;
			_userRepository = userRepository;

		}

		public async Task<double> CalculateTotalWorkload(Guid calendarId)
		{
			var jobs = await _jobRepository.GetJobsByCalendarIdAsync(calendarId);
			double workload = 0;
			foreach (var job in jobs)
			{
				workload += job.Weight;
			}
			return workload;
		}

	}
}
