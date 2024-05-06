using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
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
        public async Task GetByIdAsync_WhenCalendarExists_ReturnsSuccessResult()
        {
            //// Arrange
            //var id = Guid.NewGuid();
            //var expectedCalendar = new ApplicationCalendar { Id = id};

            //var calendarRepository = new Mock<ICalendarRepository>();
            //calendarRepository.Setup(c => c.Get)

            //// Act
            //var result = await _service.GetByIdAsync(id);

            //// Assert
            //Assert.IsTrue(result.IsSuccess);
            //Assert.AreEqual(expectedCalendar, result.Value);
            //Assert.IsNull(result.Errors);
        }

        [Fact]
        public async Task GetByIdAsync_WhenCalendarDoesNotExist_ReturnsErrorResult()
        {
            //// Arrange
            //var id = Guid.NewGuid();
            //_mockCalendarRepository.Setup(repo => repo.GetByIdAsync(id)).ReturnsAsync((ApplicationCalendar)null);

            //// Act
            //var result = await _service.GetByIdAsync(id);

            //// Assert
            //Assert.IsFalse(result.IsSuccess);
            //Assert.IsNull(result.Value);
            //Assert.IsNotNull(result.Errors);
            //Assert.AreEqual(1, result.Errors.Count);
            //Assert.AreEqual("No calendar found", result.Errors[0]);
        }
    }
}
