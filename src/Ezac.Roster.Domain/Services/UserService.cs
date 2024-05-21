using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using Ezac.Roster.Domain.Services.Models;

namespace Ezac.Roster.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ResultModel<IEnumerable<User>>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            if (users != null)
            {
                return new ResultModel<IEnumerable<User>>
                {
                    IsSucces = true,
                    Value = users
                };
            }
            return new ResultModel<IEnumerable<User>>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Geen leden gevonden!"
                }
            };
        }

        public async Task<ResultModel<User>> GetByIdAsync(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user != null)
            {
                return new ResultModel<User>
                {
                    IsSucces = true,
                    Value = user
                };
            }
            return new ResultModel<User>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Geen leden gevonden!"
                }
            };
        }

        public async Task<ResultModel<User>> AddAsync(UserCreateRequestModel userCreateRequestModel)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = userCreateRequestModel.Name,
                Created = DateTime.Now,
                Email = userCreateRequestModel.Email,
                Scaling = userCreateRequestModel.Scaling,
                IsAdmin = userCreateRequestModel.IsAdmin,
                UserPermissions = userCreateRequestModel.Permissions.ToList(),
                Preferences = userCreateRequestModel.Preferences.ToList(),
                Jobs = userCreateRequestModel.Jobs.ToList()
            };

			foreach (var permission in user.UserPermissions)
			{
				permission.UserId = user.Id;
			}

            if (await  _userRepository.AddAsync(user))
            {
                return new ResultModel<User>
                {
                    IsSucces = true,
                    Value = user
                };
            }
            return new ResultModel<User>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Kon lid niet toevoegen!"
                }
            };
        }

        public async Task<ResultModel<User>> DeleteAsync(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                return new ResultModel<User>
                {
                    IsSucces = false,
                    Errors = new List<string>
                    {
                        "Geen lid gevonden!"
                    }
                };
            }
            if(await _userRepository.DeleteAsync(user))
            {
                return new ResultModel<User>
                {
                    IsSucces = true
                };
            }
            return new ResultModel<User>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "Kon lid niet verwijderen!"
                }
            };
        }

        public async Task<ResultModel<User>> UpdateAsync(UserUpdateRequestModel userUpdateRequestModel)
        {
            var user = await _userRepository.GetByIdAsync(userUpdateRequestModel.Id);

            if (user == null)
            {
                return new ResultModel<User>
                {
                    IsSucces = false,
                    Errors = new List<string>
                    {
                        "Kon lid niet aanpassen!"
                    }
                };
            }

            var userPermissions = new List<UserPermission>();
            foreach (var permission in userUpdateRequestModel.Permissions)
            {
                userPermissions.Add(new UserPermission
                {
                    Id = Guid.NewGuid(),
                    PermissionId = permission.Id,
                    UserId = user.Id,
                    Experience = 1
                });
            }

            user.Name = userUpdateRequestModel.Name;
            user.Email = userUpdateRequestModel.Email;
            user.Scaling = userUpdateRequestModel.Scaling;
            user.IsAdmin = userUpdateRequestModel.IsAdmin;
            user.UserPermissions = userPermissions;
            user.Preferences = userUpdateRequestModel.Preferences.ToList();
            user.Jobs = userUpdateRequestModel.Jobs.ToList();

            if(await _userRepository.UpdateAsync(user))
            {
                return new ResultModel<User>
                {
                    IsSucces = true,
                    Value = user
                };
            }
            return new ResultModel<User>
            {
                IsSucces = false,
                Errors = new List<string>
                {
					"Kon lid niet aanpassen!"
				}
            };
        }

        public async Task<ResultModel<IEnumerable<User>>> SearchByNameAsync(string userName)
        {
            var users = await _userRepository.GetByNameAsync(userName);
            if (users != null)
            {
                return new ResultModel<IEnumerable<User>>
                {
                    IsSucces = true,
                    Value = users
                };
            }
            return new ResultModel<IEnumerable<User>>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "geen leden met deze naam gevonden!"
                }
            };
        }
    }
}
