using GamesStation.SuperExampleGame.Application.Interfaces;
using GamesStation.SuperExampleGame.Domain.Results;
using GamesStation.SuperExampleGame.Dto.CharacterInventoryDtos;
using GamesStation.SuperExampleGame.Service.Interfaces;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Application.Tests.StoreApplicationTests
{
    [TestFixture]
    public class BuyTest
    {
        private IStoreApplication _application;
        private Mock<ICharacterInventoryService> _characterInventoryService;

        [SetUp]
        public void SetUp()
        {
            this._characterInventoryService = new Mock<ICharacterInventoryService>();

            this._application = new StoreApplication(
                this._characterInventoryService.Object);
        }

        [Test]
        [Category("Application"), Category("Store"), Category("Buy")]
        public async Task Must_return_GenericResult_int()
        {
            //Arrange
            var request = new CharacterInventoryAddRequestDto(1, 2);
            var addResult = GenericResult<int?>.SetOk(3);

            this._characterInventoryService.Setup(r => r.Add(request))
                .ReturnsAsync(addResult);

            //Act
            var result = await this._application.Buy(request);

            //Assert
            Assert.IsAssignableFrom<GenericResult<int?>>(result);
        }

        [Test]
        [Category("Application"), Category("Store"), Category("Buy")]
        public async Task Must_call_CharacterInventoryService_Add_once()
        {
            //Arrange
            var request = new CharacterInventoryAddRequestDto(1, 2);
            var addResult = GenericResult<int?>.SetOk(3);

            this._characterInventoryService.Setup(r => r.Add(request))
                .ReturnsAsync(addResult)
                .Verifiable();

            //Act
            var result = await this._application.Buy(request);

            //Assert
            this._characterInventoryService.Verify(r =>
                r.Add(request),
                Times.Once);
        }
    }
}