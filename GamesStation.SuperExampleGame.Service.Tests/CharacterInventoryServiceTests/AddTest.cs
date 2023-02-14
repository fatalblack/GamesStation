using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Domain.Results;
using GamesStation.SuperExampleGame.Dto.CharacterInventoryDtos;
using GamesStation.SuperExampleGame.Infrastructure.Interfaces;
using GamesStation.SuperExampleGame.Service.Interfaces;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Service.Tests.CharacterInventoryServiceTests
{
    [TestFixture]
    public class AddTest
    {
        private ICharacterInventoryService _service;
        private Mock<ICharacterInventoryRepository> _repository;

        [SetUp]
        public void SetUp()
        {
            this._repository = new Mock<ICharacterInventoryRepository>();

            this._service = new CharacterInventoryService(
                this._repository.Object);
        }

        [Test]
        [Category("Service"), Category("CharacterInventory"), Category("Add")]
        public async Task Must_return_GenericResult_int_success()
        {
            //Arrange
            var request = new CharacterInventoryAddRequestDto(1, 2);
            var entity = request.AsEntity();
            const int addResult = 3;

            this._repository.Setup(r => r.Insert(It.Is<CharacterInventory>(e =>
                    e.CharacterId == entity.CharacterId &&
                    e.ItemId == entity.ItemId &&
                    e.Quantity == entity.Quantity &&
                    e.Equipped == entity.Equipped
                )))
                .ReturnsAsync(addResult);

            //Act
            var result = await this._service.Add(request);

            //Assert
            Assert.IsAssignableFrom<GenericResult<int?>>(result);
            Assert.IsTrue(result.IsSucceeded);
            Assert.AreEqual(addResult, result.Value);
        }

        [Test]
        [Category("Service"), Category("CharacterInventory"), Category("Add")]
        public async Task Must_return_GenericResult_int_fail()
        {
            //Arrange
            var request = new CharacterInventoryAddRequestDto(2, 3);
            var entity = request.AsEntity();
            const int addResult = 0;

            this._repository.Setup(r => r.Insert(It.Is<CharacterInventory>(e =>
                    e.CharacterId == entity.CharacterId &&
                    e.ItemId == entity.ItemId &&
                    e.Quantity == entity.Quantity &&
                    e.Equipped == entity.Equipped
                )))
                .ReturnsAsync(addResult);

            //Act
            var result = await this._service.Add(request);

            //Assert
            Assert.IsAssignableFrom<GenericResult<int?>>(result);
            Assert.IsFalse(result.IsSucceeded);
            Assert.IsNull(result.Value);
            Assert.AreEqual("Ocurrió un error al insertar el registro en CharacterInventory", result.Message);
        }

        [Test]
        [Category("Service"), Category("CharacterInventory"), Category("Add")]
        public async Task Must_call_Repository_Insert_once()
        {
            //Arrange
            var request = new CharacterInventoryAddRequestDto(1, 2);
            var entity = request.AsEntity();
            const int addResult = 3;

            this._repository.Setup(r => r.Insert(It.Is<CharacterInventory>(e =>
                    e.CharacterId == entity.CharacterId &&
                    e.ItemId == entity.ItemId &&
                    e.Quantity == entity.Quantity &&
                    e.Equipped == entity.Equipped
                )))
                .ReturnsAsync(addResult)
                .Verifiable();

            //Act
            var result = await this._service.Add(request);

            //Assert
            this._repository.Verify(r => r.Insert(It.Is<CharacterInventory>(e =>
                    e.CharacterId == entity.CharacterId &&
                    e.ItemId == entity.ItemId &&
                    e.Quantity == entity.Quantity &&
                    e.Equipped == entity.Equipped
                )),
                Times.Once);
        }
    }
}
