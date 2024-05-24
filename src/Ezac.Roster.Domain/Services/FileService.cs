using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using MudBlazor;
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

		public async Task<string> ImportUsers(Stream fileStream, Guid calendarId)
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
						var importResult = await ProcessUserImportRow(worksheet, row, calendarId);
						if (!string.IsNullOrEmpty(importResult))
							return importResult;
					}
				}
			}
			return "Bestand is succesvol geupload!";
		}

		private async Task ImportPermissions(ExcelWorksheet worksheet)
		{
			var existingPermissions = await _permissionRepository.GetAllAsync();
			for (int col = 3; col <= 6; col++)
			{
				var permissionName = worksheet.Cells[1, col].Value?.ToString();
                if (!existingPermissions.Any(p => p.Name == permissionName))
				{
                    var permission = new Permission
                    {
                        Id = Guid.NewGuid(),
                        Name = permissionName,
                        UserPermissions = new List<UserPermission>()
                    };
                    await _permissionRepository.AddAsync(permission);
                }
			}
		}

		private async Task<string> ProcessUserImportRow(ExcelWorksheet worksheet, int row, Guid calendarId)
		{
			var name = worksheet.Cells[row, 1].Value?.ToString();
			if (string.IsNullOrEmpty(name))
				return ImportFailed(row, 1);

			var email = worksheet.Cells[row, 2].Value?.ToString();
			if (!IsValidEmail(email))
				return ImportFailed(row, 2);

			if (!double.TryParse(worksheet.Cells[row, 7].Value?.ToString(), out double scaling) || scaling < 0)
				return ImportFailed(row, 7);

			var existingUser = await _userRepository.GetByEmailNameCalendarAsync(email, name, calendarId);
			if (existingUser == null)
			{
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    Created = DateTime.Now,
                    Email = email,
                    Scaling = scaling,
                    Preferences = new List<Preference>(),
                    UserPermissions = new List<UserPermission>(),
                    Jobs = new List<Job>(),
                    CalendarId = calendarId
                };

                await _userRepository.AddAsync(user);

                await ProcessUserPermissions(worksheet, row, user);
            }

			return null;
		}

		private async Task ProcessUserPermissions(ExcelWorksheet worksheet, int row, User user)
		{
			var permissionDictionary = new Dictionary<string, int>()
			{
				{"Instructeur", GetCellValueAsInt(worksheet.Cells[row, 3])},
				{"Lierist", GetCellValueAsInt(worksheet.Cells[row, 4])},
				{"Startofficier", GetCellValueAsInt(worksheet.Cells[row, 5])},
				{"Bar", GetCellValueAsInt(worksheet.Cells[row, 6])}
			};

			foreach (var entry in permissionDictionary.Where(entry => entry.Value > 0))
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

		private int GetCellValueAsInt(ExcelRangeBase cellValue)
		{
			return int.TryParse(cellValue.Value?.ToString(), out int result) ? result : 0;
		}

		private string ImportFailed(int row, int column)
		{
			return $"Je hebt een fout gemaakt in rij: {row}, kolom: {column}! Bekijk de template om te zien welk soort data we verwachten!";
		}

		private bool IsValidEmail(string email)
		{
			if (string.IsNullOrEmpty(email))
				return false;
			string pattern = @"..*@..*\...*";
			Match match = Regex.Match(email, pattern);
			return match.Success;
		}
	}
}
