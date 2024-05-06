using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using Ezac.Roster.Domain.Services.Models;

namespace Ezac.Roster.Domain.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<ResultModel<IEnumerable<Job>>> GetAllAsync()
        {
            var jobs = await _jobRepository.GetAllAsync();
            if (jobs != null)
            {
                return new ResultModel<IEnumerable<Job>>
                {
                    IsSucces = true,
                    Value = jobs
                };
            }
            return new ResultModel<IEnumerable<Job>>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Something went wrong!"
                }
            };
        }

        public async Task<ResultModel<Job>> GetByIdAsync(Guid id)
        {
            var job =  await _jobRepository.GetByIdAsync(id);
            if (job != null)
            {
                return new ResultModel<Job>
                {
                    IsSucces = true,
                    Value = job
                };
            }
            return new ResultModel<Job>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "No job found!"
                }
            };
        }

        public async Task<ResultModel<Job>> AddAsync(Job job)
        {
            if (await _jobRepository.AddAsync(job))
            {
                return new ResultModel<Job>
                {
                    IsSucces = true,
                    Value = job
                };
            }
            return new ResultModel<Job>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Failed to add job!"
                }
            };
        }

        public async Task<ResultModel<Job>> DeleteAsync(Guid id)
        {
            var job = await _jobRepository.GetByIdAsync(id);
            if (job == null)
            {
                return new ResultModel<Job>
                {
                    IsSucces = false,
                    Errors = new List<string>
                    {
                        "No job to delete!"
                    }
                };
            }
            if (await _jobRepository.DeleteAsync(job))
            {
                return new ResultModel<Job>
                {
                    IsSucces = true
                };
            }
            return new ResultModel<Job>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Couldn't delete this job!"
                }
            };
        }
    }
}
