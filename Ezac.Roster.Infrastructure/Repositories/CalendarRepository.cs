using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Infrastructure.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Infrastructure.Repositories
{
    public class CalendarRepository : BaseRepository<ApplicationCalendar>, ICalendarRepository
    {
        public CalendarRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<ApplicationCalendar>> logger) 
            : base(applicationDbContext, logger)
        {
        }
    }
}
