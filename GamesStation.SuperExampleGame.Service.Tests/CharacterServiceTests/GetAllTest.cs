using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Dto.CharacterDtos;
using GamesStation.SuperExampleGame.Infrastructure.Interfaces;
using GamesStation.SuperExampleGame.Service.Interfaces;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Service.Tests.CharacterServiceTests
{
    [TestFixture]
    public class GetAllTest
    {
        private ICharacterService _service;
        private Mock<IRepository<Character>> _repository;

        [SetUp]
        public void SetUp()
        {
            this._repository = new Mock<IRepository<Character>>();

            this._service = new CharacterService(
                this._repository.Object);
        }

        [Test]
        [Category("Service"), Category("Character"), Category("GetAll")]
        public async Task Must_return_List_CharacterResponseDto()
        {
            //Arrange
            var getAllResult = new List<Character>
            {
                new Character
                {
                    Id = 1,
                    Name = "Test"
                }
            };

            this._repository.Setup(r => r.GetAll())
                .ReturnsAsync(getAllResult);

            //Act
            var result = await this._service.GetAll();

            //Assert
            Assert.IsAssignableFrom<List<CharacterResponseDto>>(result);
        }

        [Test]
        [Category("Service"), Category("Character"), Category("GetAll")]
        public async Task Must_return_call_Repository_GetAll_once()
        {
            //Arrange
            var getAllResult = new List<Character>
            {
                new Character
                {
                    Id = 1,
                    Name = "Test"
                }
            };

            this._repository.Setup(r => r.GetAll())
                .ReturnsAsync(getAllResult)
                .Verifiable();

            //Act
            var result = await this._service.GetAll();

            //Assert
            this._repository.Verify(r =>
                r.GetAll(),
                Times.Once);
        }
    }
}