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
                    "No users found!"
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
                    "No user found!"
                }
            };
        }

        public async Task<ResultModel<User>> AddAsync(User user)
        {
            if (await _userRepository.AddAsync(user))
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
                    "User couldn't be added!"
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
                        "No user found to delete!"
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
                    "Couldn't delete user"
                }
            };
        }

        public async Task<ResultModel<User>> UpdateAsync(User user)
        {
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
                    "Couldn't update user"
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
                    "No users found matching this name"
                }
            };
        }
    }
}
