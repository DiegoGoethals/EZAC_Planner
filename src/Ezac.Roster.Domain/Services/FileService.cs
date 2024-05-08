using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using OfficeOpenXml;

namespace Ezac.Roster.Domain.Services
{
    public class FileService : IFileService
    {
        private readonly IUserRepository _userRepository;
		private readonly IPermissionRepository _permissionRepository;

        public FileService(IUserRepository userRepository, IPermissionRepository permissionRepository)
        {
            _userRepository = userRepository;
			_permissionRepository = permissionRepository;
        }

        public async Task ImportUsers(Stream fileStream)
        {
            using (var memoryStream = new MemoryStream())
            {
                await fileStream.CopyToAsync(memoryStream);
				ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
				using (var package = new ExcelPackage(memoryStream))
                {
					var worksheet = package.Workbook.Worksheets[0];
					var rows = worksheet.Dimension.End.Row;

					await ImportPermissions(worksheet);

					for (int row = 2; row <= rows; row++)
					{
						var user = new User
						{
							Id = Guid.NewGuid(),
							Name = worksheet.Cells[row, 1].Value?.ToString(),
							Created = DateTime.Now,
							Email = worksheet.Cells[row, 2].Value?.ToString(),
							Scaling = Double.Parse(worksheet.Cells[row, 7].Value?.ToString()),
							IsAdmin = false,
							Preferences = new List<Preference>(),
							Permissions = new List<Permission>(),
							Jobs = new List<Job>()
						};

						var permissionDictionary = new Dictionary<string, bool>()
						{
							{"Instructeur", bool.Parse(worksheet.Cells[row, 3].Value?.ToString())},
							{"Lierist", bool.Parse(worksheet.Cells[row, 4].Value?.ToString())},
							{"Startofficier", bool.Parse(worksheet.Cells[row, 5].Value?.ToString())},
							{"Bar", bool.Parse(worksheet.Cells[row, 6].Value?.ToString())}
						};

						foreach(var entry in permissionDictionary)
						{
							if(entry.Value)
							{
								var permissionAsList = await _permissionRepository.GetByNameAsync(entry.Key);
								var permission = permissionAsList.FirstOrDefault();
								permission.Users.Add(user);
								user.Permissions.Add(permission);
								await _permissionRepository.UpdateAsync(permission);
							}
						}
						await _userRepository.AddAsync(user);
					}
				}
			}
        }

		private async Task ImportPermissions(ExcelWorksheet worksheet)
		{
			for (int col = 3; col <= 6; col++)
			{
				var permission = new Permission
				{
					Id = Guid.NewGuid(),
					Name = worksheet.Cells[1, col].Value?.ToString(),
					Users = new List<User>(),
					Jobs = new List<Job>()
				};
				await _permissionRepository.AddAsync(permission);
			}
		}
    }
}
