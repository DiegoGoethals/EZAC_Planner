using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using Ezac.Roster.Domain.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Tests
{
    public class CalendarServiceTests
    {
        [Fact]
        public async void GetByIdAsync_WhenCalendarExists_ReturnsSuccessResult()
        {
            // Arrange
            var id = Guid.NewGuid();
            var expectedResult = new ApplicationCalendar { Id = id };

            var calendarRepository = new Mock<ICalendarRepository>(MockBehavior.Strict);
            calendarRepository.Setup(r => r.GetByIdAsync(It.IsAny<Guid>()))
                .ReturnsAsync(expectedResult);

            var calendarService = new CalendarService(calendarRepository.Object);
            
            // Act
            var currentResult = await calendarService.GetByIdAsync(id);

            // Assert
            Assert.True(currentResult.IsSucces);
            Assert.Equal(expectedResult, currentResult.Value);
        }

        [Fact]
        public async Task GetByIdAsync_WhenCalendarDoesNotExist_ReturnsErrorResult()
        {
            // Arrange
            var id = Guid.NewGuid();

            var calendarRepository = new Mock<ICalendarRepository>(MockBehavior.Strict);
            calendarRepository.Setup(repo => repo.GetByIdAsync(id)).ReturnsAsync((ApplicationCalendar)null);

            var calendarService = new CalendarService(calendarRepository.Object);

            // Act
            var currentResult = await calendarService.GetByIdAsync(id);

            // Assert
            Assert.False(currentResult.IsSucces);
            Assert.Equal("No calendar found", currentResult.Errors.FirstOrDefault());
        }
    }
}
