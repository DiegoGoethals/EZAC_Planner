using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services
{
    public class ExportService : IExportService
    {
        public Task ExportCalendarToExcel(ApplicationCalendar calendar, string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
