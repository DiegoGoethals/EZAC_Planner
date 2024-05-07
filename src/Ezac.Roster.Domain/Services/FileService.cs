using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using OfficeOpenXml;

namespace Ezac.Roster.Domain.Services
{
    public class FileService : IFileService
    {
        private readonly IUserRepository _userRepository;

        public FileService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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

						await _userRepository.AddAsync(user);
					}
				}
			}
        }
    }
}
