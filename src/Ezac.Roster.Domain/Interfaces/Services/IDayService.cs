using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface IDayService
    {
        Task<ResultModel<Day>> GetByIdAsync(Guid id);
        Task<ResultModel<Day>> AddAsync(Day addDay);
        Task<ResultModel<bool>> DeleteAsync(Guid id);
        Task<ResultModel<Day>> UpdateAsync(Day updateDay);
    }
}
