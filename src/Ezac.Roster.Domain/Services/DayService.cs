using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using Ezac.Roster.Domain.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services
{
    public class DayService : IDayService
    {
        private readonly IDayRepository _dayRepository;

        public DayService(IDayRepository dayRepository)
        {
            _dayRepository = dayRepository;
        }

        public async Task<ResultModel<bool>> ToggleAsync(Guid id)
        {
            try
            {
                // get the day
                var day = await _dayRepository.GetByIdAsync(id);

                if (day == null)
                {
                    return new ResultModel<bool>
                    {
                        IsSucces = false,
                        Value = false,
                        Errors = new List<string> { "Dag niet gevonden." }
                    };
                }

                // toggle de status
                day.IsOpen = !day.IsOpen;

                // update the day
                var updateResult = await _dayRepository.UpdateAsync(day);

                // check if the update is succesful
                // else return error
                if (updateResult)
                {
                    return new ResultModel<bool>
                    {
                        IsSucces = true,
                        Value = day.IsOpen,
                        Errors = new List<string> { "De dagstatus is succesvol gewijzigd." }
                    };
                }
                else
                {
                    return new ResultModel<bool>
                    {
                        IsSucces = false,
                        Value = false,
                        Errors = new List<string> { "Kan de dagstatus niet wijzigen." }
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResultModel<bool>
                {
                    IsSucces = false,
                    Value = false,
                    Errors = new List<string> { $"Er is een fout opgetreden: {ex.Message}" }
                };
            }
        }

        public async Task<ResultModel<Day>> AddAsync(Day day)
        {
            if (await _dayRepository.AddAsync(day))
            {
                return new ResultModel<Day>
                {
                    IsSucces = true,
                    Value = day
                };
            }
            else
            {
                return new ResultModel<Day>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Kan de dag niet toevoegen." }
                };
            }
        }

        public async Task<ResultModel<Day>> GetByIdAsync(Guid id)
        {
            var day = await _dayRepository.GetByIdAsync(id);
            if (day != null)
            {
                return new ResultModel<Day>
                {
                    IsSucces = true,
                    Value = day,
                };
            }
            else
            {
                return new ResultModel<Day>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Dag niet gevonden." }
                };
            }
        }
    }
}
