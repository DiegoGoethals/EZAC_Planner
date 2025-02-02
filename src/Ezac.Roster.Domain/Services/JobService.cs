﻿using Ezac.Roster.Domain.Entities;
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
                    "Geen jobs gevonden!"
                }
            };
        }

        public async Task<ResultModel<Job>> GetByIdAsync(Guid id)
        {
            var job = await _jobRepository.GetByIdAsync(id);
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
                    "Geen job gevonden!"
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
                Experience = jobCreateRequestModel.Experience,
                UserId = jobCreateRequestModel.UserId,
                DayPeriodId = jobCreateRequestModel.DayPeriodId,
                PermissionName = jobCreateRequestModel.PermissionName,
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
                    "Kon job niet toevoegen!"
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
                        "Geen job gevonden!"
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
                    "Verwijderen van job mislukt!"
                }
            };
        }

        public async Task<ResultModel<Job>> UpdateAsync(JobUpdateRequestModel jobUpdateRequestModel)
        {
            var job = await _jobRepository.GetByIdAsync(jobUpdateRequestModel.Id); // hier disposed

            if (job == null)
            {
                return new ResultModel<Job>
                {
                    IsSucces = false,
                    Errors = new List<string>
                    {
                        "Geen job gevonden!"
                    }
                };
            }

            job.Name = jobUpdateRequestModel.Name;
            job.Weight = jobUpdateRequestModel.Weight;
            job.Experience = jobUpdateRequestModel.Experience;
            job.UserId = jobUpdateRequestModel.UserId;
            job.DayPeriodId = jobUpdateRequestModel.DayPeriodId;
            job.PermissionName = jobUpdateRequestModel.PermissionName;
            job.Preferences = jobUpdateRequestModel.Preferences?.ToList() ?? new List<Preference>();

            var result = await _jobRepository.UpdateAsync(job);
            if (result)
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
                    "Kon de job niet aanpassen!"
                }
            };
        }

        public async Task<ResultModel<IEnumerable<Job>>> GetJobsByCalendarIdAsync(Guid calendarId)
        {
			var jobs = await _jobRepository.GetJobsByCalendarIdAsync(calendarId);
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
					"Geen jobs gevonden!"
				}
			};
		}
        public async Task<ResultModel<IEnumerable<Job>>> GetAllJobsByDayPeriodId(Guid id)
        {
            var jobs = await _jobRepository.GetAllJobsByDayPeriodIdAsync(id);

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
                    "Geen jobs beschikbaar"
                }
            };
        }
    }
}
