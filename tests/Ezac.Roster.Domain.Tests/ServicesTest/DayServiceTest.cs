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
            // Configureer de mock repository om null terug te geven voor dit ID
            _mockDayRepository.Setup(repo => repo.GetByIdAsync(nonExistentId))
                              .ReturnsAsync((Day)null);

            var expectedErrorMessages = new List<string> { "Dag niet gevonden." }; // Verwachte foutmelding voor dit scenario

            // Act
            var result = await _dayService.IsToggledAsync(nonExistentId); // Voer de methode uit die getest wordt

            // Assert
            Assert.False(result.IsSucces); // Controleer of de operatie niet succesvol was
            Assert.False(result.Value); // Controleer of de status van de dag niet is veranderd
            Assert.Equal(expectedErrorMessages, result.Errors); // Controleer of de verwachte foutmelding wordt geretourneerd
        }


        [Fact]
        public async Task IsToggledAsync_ToggleSuccess_ReturnsUpdatedStatus()
        {
            // Arrange
            var existingId = Guid.NewGuid();
            var existingDay = new Day { Id = existingId, IsOpen = false };

            _mockDayRepository.Setup(repo => repo.GetByIdAsync(existingId)) // Configureer de mock repository om de bestaande dag terug te geven voor dit ID
                              .ReturnsAsync(existingDay);
            _mockDayRepository.Setup(repo => repo.UpdateAsync(existingDay)) // Configureer de mock repository om true terug te geven om de update te bevestigen
                              .ReturnsAsync(true);

            // Act
            var result = await _dayService.IsToggledAsync(existingId); // Voer de methode uit die getest wordt

            // Assert
            Assert.True(result.IsSucces); // Controleer of de operatie succesvol was
            Assert.True(result.Value); // Controleer of de status van de dag is omgekeerd
            Assert.True(existingDay.IsOpen); // Controleer of de status van de dag correct is bijgewerkt in de mock repository
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
            Assert.Contains("Kan de dagstatus niet wijzigen.", result.Errors);
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

        [Fact]
        public async Task IsToggledAsync_ToggleSuccess_WithInitialOpenStatus()
        {
            // Arrange
            var existingId = Guid.NewGuid();
            var existingDay = new Day { Id = existingId, IsOpen = true };

            _mockDayRepository.Setup(repo => repo.GetByIdAsync(existingId))
                              .ReturnsAsync(existingDay);
            _mockDayRepository.Setup(repo => repo.UpdateAsync(existingDay))
                              .ReturnsAsync(true);

            // Act
            var result = await _dayService.IsToggledAsync(existingId);

            // Assert
            Assert.True(result.IsSucces);
            Assert.False(result.Value); // Omdat de initiële status open was, zou deze na het omschakelen gesloten moeten zijn
            Assert.False(existingDay.IsOpen); // Zorg ervoor dat de status van de dag correct wordt bijgewerkt
        }


    }
}
