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

                // Add the jobs to the header grouped by day periods
                var dayPeriodNames = calendar.Days.SelectMany(d => d.DayPeriods)
                    .Select(dp => dp.Name)
                    .Distinct()
                    .OrderBy(name => name)
                    .ToList();

                var jobPeriodCount = new Dictionary<string, int>();

                foreach (var period in dayPeriodNames)
                {
                    var jobNames = calendar.Days.SelectMany(d => d.DayPeriods)
                        .Where(dp => dp.Name == period)
                        .SelectMany(dp => dp.Jobs)
                        .Select(j => j.Name)
                        .Distinct()
                        .OrderBy(name => name)
                        .ToList();

                    foreach (var jobName in jobNames)
                    {
                        int count = calendar.Days.SelectMany(d => d.DayPeriods)
                            .Where(dp => dp.Name == period)
                            .SelectMany(dp => dp.Jobs)
                            .Count(j => j.Name == jobName);

                        jobPeriodCount[$"{jobName} ({period})"] = count;
                        for (int i = 1; i <= count; i++)
                        {
                            headers.Add($"{jobName} ({period}) {i}");
                        }
                    }
                }

                // Add the headers to the first row
                for (int i = 0; i < headers.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = headers[i];
                }

                // Sort days by date
                var sortedDays = calendar.Days.OrderBy(d => d.Date).ToList();
                int row = 2;

                foreach (var day in sortedDays)
                {
                    // Add the date to the first column (once per day)
                    worksheet.Cell(row, 1).Value = day.Date.ToString("dddd dd MMM yyyy", CultureInfo.CurrentCulture);

                    var jobAssignments = new Dictionary<string, List<string>>();

                    foreach (var dayPeriod in day.DayPeriods)
                    {
                        foreach (var job in dayPeriod.Jobs.Where(j => j.User != null))
                        {
                            string key = $"{job.Name} ({dayPeriod.Name})";
                            if (!jobAssignments.ContainsKey(key))
                            {
                                jobAssignments[key] = new List<string>();
                            }
                            jobAssignments[key].Add(job.User.Name ?? "");
                        }
                    }

                    for (int i = 1; i < headers.Count; i++)
                    {
                        string header = headers[i];
                        string jobKey = header.Substring(0, header.LastIndexOf(' '));
                        int occurrence = int.Parse(header.Substring(header.LastIndexOf(' ') + 1));

                        if (jobAssignments.TryGetValue(jobKey, out List<string> userNames) && userNames.Count >= occurrence)
                        {
                            worksheet.Cell(row, i + 1).Value = userNames[occurrence - 1];
                        }
                        else
                        {
                            // add an empty cell
                            worksheet.Cell(row, i + 1).Value = "";
                        }
                    }
                    row++;
                }

                // Hide empty columns
                for (int col = 2; col <= worksheet.LastColumnUsed().ColumnNumber(); col++)
                {
                    bool isEmpty = true;
                    for (int r = 2; r <= worksheet.LastRowUsed().RowNumber(); r++)
                    {
                        if (!string.IsNullOrEmpty(worksheet.Cell(r, col).GetString()))
                        {
                            isEmpty = false;
                            break;
                        }
                    }
                    if (isEmpty)
                    {
                        worksheet.Column(col).Hide();
                    }
                }

                worksheet.Columns().AdjustToContents();

                // Save the workbook to a memory stream
                var stream = new MemoryStream();
                workbook.SaveAs(stream);
                stream.Position = 0;

                return stream;
            }
        }


    }
}
