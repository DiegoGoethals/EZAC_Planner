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
	public class PermissionService : IPermissionsService
	{
		private readonly IPermissionRepository _permissionRepository;
		private readonly IUserRepository _userRepository;

		public PermissionService(IPermissionRepository permissionRepository, IUserRepository userRepository)
		{
			_permissionRepository = permissionRepository;
			_userRepository = userRepository;
		}

		public async Task<ResultModel<Permission>> AddAsync(Permission permission)
		{
			if (await _permissionRepository.AddAsync(permission))
			{
				return new ResultModel<Permission>
				{
					IsSucces = true,
					Value = permission
				};
			}
			return new ResultModel<Permission>
			{
				IsSucces = false,
				Errors = new List<string>
				{
					"Permission couldn't be added!"
				}
			};
		}

		public async Task<ResultModel<Permission>> DeleteAsync(Guid id)
		{
			var permission = await _permissionRepository.GetByIdAsync(id);
			if (permission == null)
			{
				return new ResultModel<Permission>
				{
					IsSucces = false,
					Errors = new List<string>
					{
						"No user found to delete!"
					}
				};
			}
			if (await _permissionRepository.DeleteAsync(permission))
			{
				return new ResultModel<Permission>
				{
					IsSucces = true
				};
			}
			return new ResultModel<Permission>
			{
				IsSucces = false,
				Errors = new List<string>
				{
					"Couldn't delete Permission"
				}
			};
		}

		public async Task<ResultModel<IEnumerable<Permission>>> GetAllByUserIdAsync(Guid userId)
		{
			var user = await _userRepository.GetByIdAsync(userId);
			var permissions = user.Permissions;

			if (permissions != null)
			{
				return new ResultModel<IEnumerable<Permission>>
				{
					IsSucces = true,
					Value = permissions
				};
			}
			return new ResultModel<IEnumerable<Permission>>
			{
				IsSucces = false,
				Errors = new List<string>
				{
					"No permissions found for this user"
				}
			};
		}

		public async Task<ResultModel<Permission>> GetByIdAsync(Guid id)
		{
			var permission = await _permissionRepository.GetByIdAsync(id);
			if (permission != null)
			{
				return new ResultModel<Permission>
				{
					IsSucces = true,
					Value = permission
				};
			}
			return new ResultModel<Permission>
			{
				IsSucces = false,
				Errors = new List<string>
				{
					"No permission found!"
				}
			};
		}

		public async Task<ResultModel<IEnumerable<Permission>>> SearchByNameAsync(string name)
		{
			var permissions = await _permissionRepository.GetByNameAsync(name);
			if (permissions != null)
			{
				return new ResultModel<IEnumerable<Permission>>
				{
					IsSucces = true,
					Value = permissions
				};
			}
			return new ResultModel<IEnumerable<Permission>>
			{
				IsSucces = false,
				Errors = new List<string>
				{
					"No permission found matching this name"
				}
			};
		}

		public async Task<ResultModel<Permission>> UpdateAsync(Permission permission)
		{
			if (await _permissionRepository.UpdateAsync(permission))
			{
				return new ResultModel<Permission>
				{
					IsSucces = true,
					Value = permission
				};
			}
			return new ResultModel<Permission>
			{
				IsSucces = false,
				Errors = new List<string>
				{
					"Couldn't update permission"
				}
			};
		}
	}
}
