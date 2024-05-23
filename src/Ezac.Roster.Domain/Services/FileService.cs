using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using OfficeOpenXml;
using System.Text.RegularExpressions;

namespace Ezac.Roster.Domain.Services
{
    public class FileService : IFileService
    {
        private readonly IUserRepository _userRepository;
		private readonly IPermissionRepository _permissionRepository;
		private readonly IUserPermissionRepository _userPermissionRepository;

        public FileService(IUserRepository userRepository, IPermissionRepository permissionRepository, IUserPermissionRepository userPermissionRepository)
        {
            _userRepository = userRepository;
			_permissionRepository = permissionRepository;
			_userPermissionRepository = userPermissionRepository;
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
						if (name== null || name.Length == 0 || !(name.GetType() == typeof(string)))
						{
							return ImportFailed(row, 1);
						}
						var email = worksheet.Cells[row, 2].Value?.ToString();
						if (email == null)
						{
                            return ImportFailed(row, 2);
                        }
						string pattern = @"..*@..*\...*";
						Match match = Regex.Match(email, pattern);
						if (!match.Success || !(email.GetType() == typeof(string)))
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
							Preferences = new List<Preference>(),
							UserPermissions = new List<UserPermission>(),
							Jobs = new List<Job>()
						};

                        await _userRepository.AddAsync(user);

                        if (!int.TryParse(worksheet.Cells[row, 3].Value?.ToString(), out int instructeur))
						{
							return ImportFailed(row, 3);
						}
						if (!int.TryParse(worksheet.Cells[row, 4].Value?.ToString(), out int lierist))
						{
							return ImportFailed(row, 4);
						}
						if (!int.TryParse(worksheet.Cells[row, 5].Value?.ToString(), out int startofficier))
						{
							return ImportFailed(row, 5);
						}
						if (!int.TryParse(worksheet.Cells[row, 6].Value?.ToString(), out int bar))
						{
							return ImportFailed(row, 6);
						}

						var permissionDictionary = new Dictionary<string, int>()
						{
							{"Instructeur", instructeur},
							{"Lierist", lierist},
							{"Startofficier", startofficier},
							{"Bar", bar}
						};

						foreach(var entry in permissionDictionary)
						{
							if(entry.Value > 0)
							{
								var permissionAsList = await _permissionRepository.GetByNameAsync(entry.Key);
								var permission = permissionAsList.FirstOrDefault();
								var userPermission = new UserPermission
								{
                                    Id = Guid.NewGuid(),
                                    UserId = user.Id,
                                    PermissionId = permission.Id,
									Name = permission.Name,
                                    Experience = entry.Value
                                };
								await _userPermissionRepository.AddAsync(userPermission);
								permission.UserPermissions.Add(userPermission);
								user.UserPermissions.Add(userPermission);
								await _permissionRepository.UpdateAsync(permission);
								await _userRepository.UpdateAsync(user);
							}
						}
					}
				}
			}
			return "Bestand is succesvol geupload!";
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
					UserPermissions = new List<UserPermission>()
				};
				await _permissionRepository.AddAsync(permission);
			}
		}

		private string ImportFailed(int row, int column)
		{
			return $"Je hetb een fout gemaakt in rij: {row}, kolom: {column}! Bekijk de template om te zien welk soort data we verwachten!";
		}
    }
}
