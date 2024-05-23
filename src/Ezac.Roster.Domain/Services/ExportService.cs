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

                // add the jobs to the header grouped by day periods
                var dayPeriodNames = calendar.Days.SelectMany(d => d.DayPeriods)
                    .Select(dp => dp.Name)
                    .Distinct()
                    .OrderBy(name => name)
                    .ToList();

                foreach (var period in dayPeriodNames)
                {
                    var jobNames = calendar.Days.SelectMany(d => d.DayPeriods)
                        .Where(dp => dp.Name == period)
                        .SelectMany(dp => dp.Jobs)
                        .GroupBy(j => j.Name)
                        .OrderBy(g => g.Key)
                        .ToList();

                    foreach (var group in jobNames)
                    {
                        int count = 1;
                        foreach (var job in group)
                        {
                            headers.Add($"{job.Name} ({period}) {count}");
                            count++;
                        }
                    }
                }


                // add the headers to the first row
                for (int i = 0; i < headers.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = headers[i];
                }

                // Sort days by date
                var sortedDays = calendar.Days.OrderBy(d => d.Date).ToList();
                int row = 2;

                foreach (var day in sortedDays)
                {
                    // dd the date to the first column (once per day)
                    worksheet.Cell(row, 1).Value = day.Date.ToString("dddd dd MMM yyyy", CultureInfo.CurrentCulture);

                    var jobAssignments = new Dictionary<string, string>();

                    foreach (var dayPeriod in day.DayPeriods)
                    {
                        foreach (var job in dayPeriod.Jobs.Where(j => j.User != null))
                        {
                            string key = $"{job.Name} ({dayPeriod.Name})";
                            if (!jobAssignments.ContainsKey(key))
                            {
                                jobAssignments[key] = job.User.Name ?? "";
                            }
                            else
                            {
                                jobAssignments[key] += $", {job.User.Name ?? ""}";
                            }
                        }
                    }

                    for (int i = 1; i < headers.Count; i++)
                    {
                        if (jobAssignments.TryGetValue(headers[i], out string userName))
                        {
                            // add the user name to the cell
                            worksheet.Cell(row, i + 1).Value = userName;
                        }
                        else
                        {
                            // add an empty cell
                            worksheet.Cell(row, i + 1).Value = "";
                        }
                    }
                    row++;
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
