using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using Ezac.Roster.Domain.Services.Models;
using System.Xml.Linq;

namespace Ezac.Roster.Domain.Services
{
    public class PreferenceService : IPreferenceService
    {
        private readonly IPreferenceRepository _preferenceRepository;

        public PreferenceService(IPreferenceRepository preferenceRepository)
        {
            _preferenceRepository = preferenceRepository;
        }

        public async Task<ResultModel<IEnumerable<Preference>>> GetAllAsync()
        {
            var preferences = await _preferenceRepository.GetAllAsync();
            if (preferences != null)
            {
                return new ResultModel<IEnumerable<Preference>>
                {
                    IsSucces = true,
                    Value = preferences
                };
            }
            return new ResultModel<IEnumerable<Preference>>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Geen voorkeuren gevonden!"
                }
            };
        }

        public async Task<ResultModel<Preference>> GetByIdAsync(Guid id)
        {
            var preference = await _preferenceRepository.GetByIdAsync(id);
            if (preference != null)
            {
                return new ResultModel<Preference>
                {
                    IsSucces = true,
                    Value = preference
                };
            }
            return new ResultModel<Preference>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Geen voorkeuren gevonden!"
                }
            };
        }

        public async Task<ResultModel<Preference>> AddAsync(PreferenceCreateRequestModel preferenceCreateRequestModel)
        {
            var preference = new Preference
            {
                Id = Guid.NewGuid(),
                Name = preferenceCreateRequestModel.Name,
                Created = DateTime.Now,
                Available = preferenceCreateRequestModel.Available,
                UserId = preferenceCreateRequestModel.UserId,
                DayPeriodId = preferenceCreateRequestModel.DayPeriodId,
                DayId = preferenceCreateRequestModel.DayId,
                JobId = preferenceCreateRequestModel.JobId
            };
            if (await _preferenceRepository.AddAsync(preference))
            {
                return new ResultModel<Preference>
                {
                    IsSucces = true,
                    Value = preference
                };
            }
            return new ResultModel<Preference>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Kon voorkeur niet creeëren!"
                }
            };
        }

        public async Task<ResultModel<Preference>> DeleteAsync(Guid id)
        {
            var preference = await _preferenceRepository.GetByIdAsync(id);
            if ( preference == null )
            {
                return new ResultModel<Preference>
                {
                    IsSucces = false,
                    Errors = new List<string>
                    {
                        "Kon voorkeur niet verwijderen!"
                    }
                };
            }
            if (await _preferenceRepository.DeleteAsync(preference))
            {
                return new ResultModel<Preference>
                {
                    IsSucces = true
                };
            }
            return new ResultModel<Preference>
            {
                IsSucces = false,
                Errors = new List<string>
                {
					"Kon voorkeur niet verwijderen!"
				}
            };
        }

        public async Task<ResultModel<Preference>> UpdateAsync(PreferenceUpdateRequestModel preferenceUpdateRequestModel)
        {
            var preference = await _preferenceRepository.GetByIdAsync(preferenceUpdateRequestModel.Id);

            if ( preference == null )
            {
                return new ResultModel<Preference>
                {
                    IsSucces = false,
                    Errors = new List<string>
                    {
                        "Kon voorkeur niet aanpassen!"
                    }
                };
            }

            preference.Name = preferenceUpdateRequestModel.Name;
            preference.Updated = DateTime.Now;
            preference.Available = preferenceUpdateRequestModel.Available;
            preference.UserId = preferenceUpdateRequestModel.UserId;
            preference.DayPeriodId = preferenceUpdateRequestModel.DayPeriodId;
            preference.DayId = preferenceUpdateRequestModel.DayId;
            preference.JobId = preferenceUpdateRequestModel.JobId;

            if (await _preferenceRepository.UpdateAsync(preference))
            {
                return new ResultModel<Preference>
                {
                    IsSucces = true,
                    Value = preference
                };
            }
            return new ResultModel<Preference>
            {
                IsSucces = false,
                Errors = new List<string>
                {
					"Kon voorkeur niet aanpassen!"
				}
            };
        }
    }
}
