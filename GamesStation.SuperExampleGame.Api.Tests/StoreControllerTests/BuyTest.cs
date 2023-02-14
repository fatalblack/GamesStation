using GamesStation.SuperExampleGame.Api.Controllers;
using GamesStation.SuperExampleGame.Application.Interfaces;
using GamesStation.SuperExampleGame.Domain.Results;
using GamesStation.SuperExampleGame.Dto.CharacterInventoryDtos;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Api.Tests.StoreControllerTests
{
    [TestFixture]
    public class BuyTest
    {
        private StoreController _controller;
        private Mock<IStoreApplication> _storeApplication;

        private readonly int OK_STATUS_CODE = 200;

        [SetUp]
        public void SetUp()
        {
            this._storeApplication = new Mock<IStoreApplication>();

            this._controller = new StoreController(
                this._storeApplication.Object);
        }

        [Test]
        [Category("Controller"), Category("Store"), Category("Buy")]
        public async Task Must_return_GenericResult_int()
        {
            //Arrange
            var request = new CharacterInventoryAddRequestDto(1, 2);
            var buyResult = GenericResult<int?>.SetOk(3);

            this._storeApplication.Setup(r => r.Buy(request))
                .ReturnsAsync(buyResult);

            //Act
            var actionResult = await this._controller.Buy(request);
            var result = actionResult as OkObjectResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(this.OK_STATUS_CODE, result.StatusCode);
            Assert.IsAssignableFrom<GenericResult<int?>>(result.Value);
        }

        [Test]
        [Category("Controller"), Category("Store"), Category("Buy")]
        public async Task Must_call_StoreApplication_Buy_once()
        {
            //Arrange
            var request = new CharacterInventoryAddRequestDto(1, 2);
            var buyResult = GenericResult<int?>.SetOk(3);

            this._storeApplication.Setup(r => r.Buy(request))
                .ReturnsAsync(buyResult)
                .Verifiable();

            //Act
            var actionResult = await this._controller.Buy(request);

            //Assert
            this._storeApplication.Verify(r =>
                r.Buy(request),
                Times.Once);
        }
    }
}