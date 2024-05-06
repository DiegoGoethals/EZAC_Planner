using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Tests.ServicesTest
{
    public class DayServiceTests
    {
        private readonly Mock<IDayRepository> _mockDayRepository;
        private readonly DayService _dayService;

        public DayServiceTests()
        {
            _mockDayRepository = new Mock<IDayRepository>();
            _dayService = new DayService(_mockDayRepository.Object);
        }

        [Fact]
        public async Task IsToggledAsync_DayNotFound_ReturnsError()
        {
            // Arrange
            var nonExistentId = Guid.NewGuid();
            _mockDayRepository.Setup(repo => repo.GetByIdAsync(nonExistentId))
                              .ReturnsAsync((Day)null);

            var expectedErrorMessages = new List<string> { "Dag niet gevonden." };

            // Act
            var result = await _dayService.IsToggledAsync(nonExistentId);

            // Assert
            Assert.False(result.IsSucces);
            Assert.False(result.Value);
            Assert.Equal(expectedErrorMessages, result.Errors);
        }



        [Fact]
        public async Task IsToggledAsync_ToggleSuccess_ReturnsUpdatedStatus()
        {
            // Arrange
            var existingId = Guid.NewGuid();
            var existingDay = new Day { Id = existingId, IsOpen = false };

            _mockDayRepository.Setup(repo => repo.GetByIdAsync(existingId))
                              .ReturnsAsync(existingDay);
            _mockDayRepository.Setup(repo => repo.UpdateAsync(existingDay))
                              .ReturnsAsync(true);

            // Act
            var result = await _dayService.IsToggledAsync(existingId);

            // Assert
            Assert.True(result.IsSucces);
            Assert.True(result.Value);
            Assert.True(existingDay.IsOpen);
        }

        [Fact]
        public async Task IsToggledAsync_UpdateFailed_ReturnsError()
        {
            // Arrange
            var existingId = Guid.NewGuid();
            var existingDay = new Day { Id = existingId, IsOpen = false };

            _mockDayRepository.Setup(repo => repo.GetByIdAsync(existingId))
                              .ReturnsAsync(existingDay);
            _mockDayRepository.Setup(repo => repo.UpdateAsync(existingDay))
                              .ReturnsAsync(false);

            // Act
            var result = await _dayService.IsToggledAsync(existingId);

            // Assert
            Assert.False(result.IsSucces);
            Assert.False(result.Value);
        }

        [Fact]
        public async Task IsToggledAsync_ToggleSuccess_WithInitialClosedStatus()
        {
            // Arrange
            var existingId = Guid.NewGuid();
            var existingDay = new Day { Id = existingId, IsOpen = false };

            _mockDayRepository.Setup(repo => repo.GetByIdAsync(existingId))
                              .ReturnsAsync(existingDay);
            _mockDayRepository.Setup(repo => repo.UpdateAsync(existingDay))
                              .ReturnsAsync(true);

            // Act
            var result = await _dayService.IsToggledAsync(existingId);

            // Assert
            Assert.True(result.IsSucces);
            Assert.True(result.Value);
            Assert.True(existingDay.IsOpen);
        }

    }
}
