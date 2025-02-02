﻿using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Services.Models;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface IJobService
    {
        Task<ResultModel<IEnumerable<Job>>> GetAllAsync();
        Task<ResultModel<Job>> GetByIdAsync(Guid id);
        Task<ResultModel<Job>> AddAsync(JobCreateRequestModel jobCreateRequestModel);
        Task<ResultModel<Job>> DeleteAsync(Guid id);
        Task<ResultModel<Job>> UpdateAsync(JobUpdateRequestModel jobUpdateRequestModel);
        Task<ResultModel<IEnumerable<Job>>> GetAllJobsByDayPeriodId(Guid id);
    }
}
