using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using Ezac.Roster.Domain.Services.Models;
using OfficeOpenXml;
using System.Text.RegularExpressions;

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

        public async Task<string> ImportUsers(Stream fileStream)
        {
			await _userRepository.DeleteAllAsync();
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
						var name = worksheet.Cells[row, 1].Value?.ToString();
						if (name.Length > 0 && name!= null && !(name.GetType() == typeof(string)))
						{
							return ImportFailed(row, 1);
						}
						var email = worksheet.Cells[row, 2].Value?.ToString();
						string pattern = @"..*@..*\...*";
						Match match = Regex.Match(email, pattern);
						if (match.Success && email != null && !(email.GetType() == typeof(string)))
						{
							return ImportFailed(row, 2);
						}
						if (!Double.TryParse(worksheet.Cells[row, 7].Value?.ToString(), out double scaling))
						{
							return ImportFailed(row, 7);
						}
						if (scaling < 0 ) // Add check for smaller or equal to 1 if needed as well
						{
							return ImportFailed(row, 7);
						}

						var user = new User
						{
							Id = Guid.NewGuid(),
							Name = name,
							Created = DateTime.Now,
							Email = email,
							Scaling = scaling,
							IsAdmin = false,
							Preferences = new List<Preference>(),
							Permissions = new List<Permission>(),
							Jobs = new List<Job>()
						};

						if (!bool.TryParse(worksheet.Cells[row, 3].Value?.ToString(), out bool instructeur))
						{
							return ImportFailed(row, 3);
						}
						if (!bool.TryParse(worksheet.Cells[row, 4].Value?.ToString(), out bool lierist))
						{
							return ImportFailed(row, 4);
						}
						if (!bool.TryParse(worksheet.Cells[row, 5].Value?.ToString(), out bool startofficier))
						{
							return ImportFailed(row, 5);
						}
						if (!bool.TryParse(worksheet.Cells[row, 6].Value?.ToString(), out bool bar))
						{
							return ImportFailed(row, 6);
						}

						var permissionDictionary = new Dictionary<string, bool>()
						{
							{"Instructeur", instructeur},
							{"Lierist", lierist},
							{"Startofficier", startofficier},
							{"Bar", bar}
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
			return "File Uploaded successfully!";
        }

		private async Task ImportPermissions(ExcelWorksheet worksheet)
		{
			await _permissionRepository.DeleteAllAsync();
			for (int col = 3; col <= 6; col++)
			{
				var permission = new Permission
				{
					Id = Guid.NewGuid(),
					Name = worksheet.Cells[1, col].Value?.ToString(),
					Users = new List<User>()
				};
				await _permissionRepository.AddAsync(permission);
			}
		}

		private string ImportFailed(int row, int column)
		{
			return $"You made a mistake inside the file at row: {row}, column: {column}! Please see our template to see what type of values we expect!";
		}
    }
}
