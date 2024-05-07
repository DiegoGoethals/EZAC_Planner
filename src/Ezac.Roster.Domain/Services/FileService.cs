using ExcelDataReader;
using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using System.Data;

namespace Ezac.Roster.Domain.Services
{
    public class FileService : IFileService
    {
        private readonly IUserRepository _userRepository;

        public FileService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        private static string GetColumnValue(IDataReader reader, List<string> columnNames, string columnName)
        {
            var columnIndex = columnNames.IndexOf(columnName);
            return reader.GetValue(columnIndex)?.ToString();
        }

        public async Task ImportUsers(Stream fileStream)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

			using var reader = ExcelReaderFactory.CreateReader(fileStream);
			var columnNames = new List<string>();

			reader.Read();
			for (int column = 0; column < reader.FieldCount; column++)
			{
				columnNames.Add(reader.GetValue(column)?.ToString());
			}

            while(reader.Read())
            {
                var user = new User
                {
                    Id = Guid.NewGuid(),
                    Created = DateTime.Now,
                    Name = GetColumnValue(reader, columnNames, "Name"),
                    Email = GetColumnValue(reader, columnNames, "Email"),
                    Scaling = Double.Parse(GetColumnValue(reader, columnNames, "Inschaling")),
                    IsAdmin = false
                };
                await _userRepository.AddAsync(user);
            }
		}
    }
}
