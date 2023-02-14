using GamesStation.SuperExampleGame.Application.Interfaces;
using GamesStation.SuperExampleGame.Dto.CharacterDtos;
using GamesStation.SuperExampleGame.Service.Interfaces;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Application.Tests.CharacterApplicationTests
{
    [TestFixture]
    public class GetAllTest
    {
        private ICharacterApplication _application;
        private Mock<ICharacterService> _characterService;

        [SetUp]
        public void SetUp()
        {
            this._characterService = new Mock<ICharacterService>();

            this._application = new CharacterApplication(
                this._characterService.Object);
        }

        [Test]
        [Category("Application"), Category("Character"), Category("GetAll")]
        public async Task Must_return_List_CharacterResponseDto()
        {
            //Arrange
            var getAllResult = new List<CharacterResponseDto>
            {
                new CharacterResponseDto
                {
                    Id = 1,
                    Name = "Test"
                }
            };

            this._characterService.Setup(r => r.GetAll())
                .ReturnsAsync(getAllResult);

            //Act
            var result = await this._application.GetAll();

            //Assert
            Assert.IsAssignableFrom<List<CharacterResponseDto>>(result);
        }

        [Test]
        [Category("Application"), Category("Character"), Category("GetAll")]
        public async Task Must_return_call_Service_GetAll_once()
        {
            //Arrange
            var getAllResult = new List<CharacterResponseDto>
            {
                new CharacterResponseDto
                {
                    Id = 1,
                    Name = "Test"
                }
            };

            this._characterService.Setup(r => r.GetAll())
                .ReturnsAsync(getAllResult);

            //Act
            var result = await this._application.GetAll();

            //Assert
            this._characterService.Verify(r =>
                r.GetAll(),
                Times.Once);
        }
    }
}