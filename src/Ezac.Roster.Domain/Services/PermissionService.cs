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

		public async Task<ResultModel<Permission>> AddAsync(PermissionCreateRequestModel permissionCreateRequestModel)
		{

			var permission = new Permission
			{
				Id = Guid.NewGuid(),
				Name = permissionCreateRequestModel.Name,
				Created = DateTime.Now,
				Users = permissionCreateRequestModel.Users.ToList(),
			};

			var result = await _permissionRepository.AddAsync(permission);

			if (result)
			{
				var createdPermission = await GetByIdAsync(permission.Id);
				return new ResultModel<Permission>
				{
					IsSucces = true,
					Value = createdPermission.Value,
				};
			}
			return new ResultModel<Permission>
			{
				IsSucces = false,
				Errors = new List<string> 
				{
					"Permission not created!"
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

        public async Task<ResultModel<IEnumerable<Permission>>> GetAllAsync()
        {
            var permissions = await _permissionRepository.GetAllAsync();
			if(permissions == null)
			{
                return new ResultModel<IEnumerable<Permission>>
                {
                    IsSucces = false,
                    Errors = new List<string>{"No permissions found for this user"}
                };
            }

			return new ResultModel<IEnumerable<Permission>>
			{
				IsSucces = true,
				Value = permissions
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

		public async Task<ResultModel<Permission>> UpdateAsync(PermissionUpdateRequestModel permissionUpdateRequestModel)
		{
			var selectedPermission = await _permissionRepository.GetByIdAsync(permissionUpdateRequestModel.Id);

			if (selectedPermission == null)
			{
				return new ResultModel<Permission>
				{
					IsSucces = false,
					Errors = new List<string> 
					{
						"Permission not found!"
					}
				};
			}

			selectedPermission.Id = permissionUpdateRequestModel.Id;
			selectedPermission.Name = permissionUpdateRequestModel.Name;	
			selectedPermission.Updated = permissionUpdateRequestModel.Updated;
			selectedPermission.Users = permissionUpdateRequestModel.Users.ToList();

			if (await _permissionRepository.UpdateAsync(selectedPermission))
			{
				return new ResultModel<Permission>
				{
					IsSucces = true,
					Value = selectedPermission,
				};
			}

			return new ResultModel<Permission>
			{
				IsSucces = false,
				Errors = new List<string> { "Permission update failed!" }
			};
		}
	}
}
