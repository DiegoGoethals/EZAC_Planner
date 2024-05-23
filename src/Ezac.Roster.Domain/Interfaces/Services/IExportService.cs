using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface IExportService
    {
        Task<Stream> ExportCalendarToExcel(string calendarId);
    }
}
