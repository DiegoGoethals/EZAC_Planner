using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using Ezac.Roster.Domain.Services.Models;

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
                    "No preferences found!"
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
                    "No preference found!"
                }
            };
        }

        public async Task<ResultModel<Preference>> AddAsync(Preference preference)
        {
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
                    "Couldn't add preference!"
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
                        "Couldn't find preference to delete"
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
                    "Couldn't delete preference!"
                }
            };
        }

        public async Task<ResultModel<Preference>> UpdateAsync(Preference preference)
        {
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
                    "Couldn't update preference"
                }
            };
        }
    }
}
