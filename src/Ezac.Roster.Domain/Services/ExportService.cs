using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using MudBlazor;
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
        private readonly IExportRepository _exportRepository;

        public ExportService(IExportRepository exportRepository)
        {
            _exportRepository = exportRepository;
        }

        public async Task<Stream> ExportCalendarToExcel(Guid calendarId)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Calendar");

                var calendar = await _exportRepository.GetCalendarForExportAsync(calendarId);

                if (calendar == null)
                {
                    throw new Exception("Calendar not found");
                }

                // Get the year of the first day in the calendar
                int year = calendar.Days.First().Date.Year;

                // Create the header
                var headers = new List<string> { $"Periode {year}" };

                // Add the jobs to the header
                var jobsNames = calendar.Days.SelectMany(d => d.DayPeriods)
                    .SelectMany(dp => dp.Jobs)
                    .Select(j => j.Name)
                    .Distinct()
                    .ToList();

                if (jobsNames != null)
                {
                    headers.AddRange(jobsNames);
                }

                // get the maximum number of jobs per day period to add additional headers if necessary
                int maxJobsPerDayPeriod = calendar.Days.SelectMany(d => d.DayPeriods).Max(dp => dp.Jobs.Count());

                while (headers.Count < maxJobsPerDayPeriod + 1)
                {
                    headers.Add("");  // add empty headers to fill the row
                }

                // add the headers to the first row
                for (int i = 0; i < headers.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = headers[i];
                }

                int row = 2;
                foreach (var day in calendar.Days)
                {
                    foreach (var dayPeriod in day.DayPeriods)
                    {
                        // add the date to the first column
                        worksheet.Cell(row, 1).Value = day.Date.ToString("dddd dd MMM yyyy", CultureInfo.CurrentCulture);
                        //worksheet.Cell(row, 1).Value = day.Date.ToString("dddd dd MMM yyyy", new CultureInfo("nl-NL"));

                        // create a dictionary with the job names as keys and the user names as values
                        var jobDict = dayPeriod.Jobs
                            .Where(job => job.User != null) 
                            .ToDictionary(job => job.Name, job => job.User.Name ?? "");

                        for (int i = 1; i < headers.Count; i++)
                        {
                            if (jobDict.TryGetValue(headers[i], out string userName))
                            {
                                // add the user name to the cell
                                worksheet.Cell(row, i + 1).Value = userName;
                            }
                            else
                            {
                                // add an empty cell
                                worksheet.Cell(row, i + 1).Value = "Er is geen gebruiker in database";
                            }
                        }
                        row++;
                    }
                }

                // Save the workbook to a memory stream
                var stream = new MemoryStream();
                workbook.SaveAs(stream);
                stream.Position = 0;

                return stream;
            }
        }
    }
}
