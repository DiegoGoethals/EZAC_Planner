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
                    "Could not find any jobs!"
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

        public async Task<ResultModel<Job>> AddAsync(JobCreateRequestModel jobCreateRequestModel)
        {
            var job = new Job
            {
                Id = Guid.NewGuid(),
                Name = jobCreateRequestModel.Name,
                Created = DateTime.Now,
                Weight = jobCreateRequestModel.Weight,
                UserId = jobCreateRequestModel.UserId,
                DayPeriodId = jobCreateRequestModel.DayPeriodId,
                PermissionId = jobCreateRequestModel.PermissionId,
                Preferences = jobCreateRequestModel.Preferences.ToList()
            };
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

        public async Task<ResultModel<Job>> UpdateAsync(JobUpdateRequestModel jobUpdateRequestModel)
        {
            var job = await _jobRepository.GetByIdAsync(jobUpdateRequestModel.Id);

            if (job == null)
            {
                return new ResultModel<Job>
                {
                    IsSucces = false,
                    Errors = new List<string>
                    {
                        "No job found to update!"
                    }
                };
            }

            job.Name = jobUpdateRequestModel.Name;
            job.Weight = jobUpdateRequestModel.Weight;
            job.UserId = jobUpdateRequestModel.UserId;
            job.DayPeriodId = jobUpdateRequestModel.DayPeriodId;
            job.PermissionId = jobUpdateRequestModel.PermissionId;
            job.Preferences = jobUpdateRequestModel.Preferences.ToList();

            if (await _jobRepository.UpdateAsync(job))
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
                    "Couldn't update job!"
                }
            };
        }
    }
}
