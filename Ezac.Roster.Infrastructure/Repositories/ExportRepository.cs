using DocumentFormat.OpenXml.InkML;
using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Infrastructure.Repositories
{
    public class ExportRepository : IExportRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ExportRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<ApplicationCalendar> GetCalendarForExportAsync(Guid calendarId)
        {
            return await _applicationDbContext.Calendars
                .Include(c => c.Days)
                .ThenInclude(d => d.DayPeriods)
                .ThenInclude(dp => dp.Jobs)
                .ThenInclude(j => j.User)
                .FirstOrDefaultAsync(c => c.Id == calendarId);
        }
    }
}
