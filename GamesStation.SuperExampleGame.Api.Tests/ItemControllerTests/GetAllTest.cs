using GamesStation.SuperExampleGame.Api.Controllers;
using GamesStation.SuperExampleGame.Application.Interfaces;
using GamesStation.SuperExampleGame.Dto.ItemDtos;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Api.Tests.ItemControllerTests
{
    [TestFixture]
    public class GetAllTest
    {
        private ItemController _controller;
        private Mock<IItemApplication> _itemApplication;

        private readonly int OK_STATUS_CODE = 200;

        [SetUp]
        public void SetUp()
        {
            this._itemApplication = new Mock<IItemApplication>();

            this._controller = new ItemController(
                this._itemApplication.Object);
        }

        [Test]
        [Category("Controller"), Category("Item"), Category("GetAll")]
        public async Task Must_return_List_itemResponseDto()
        {
            //Arrange
            var getAllResult = new List<ItemResponseDto>
            {
                new ItemResponseDto
                {
                    Id = 1,
                    Name = "Test"
                }
            };

            this._itemApplication.Setup(r => r.GetAll())
                .ReturnsAsync(getAllResult);

            //Act
            var actionResult = await this._controller.GetAll();
            var result = actionResult as OkObjectResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(this.OK_STATUS_CODE, result.StatusCode);
            Assert.IsAssignableFrom<List<ItemResponseDto>>(result.Value);
        }

        [Test]
        [Category("Controller"), Category("Item"), Category("GetAll")]
        public async Task Must_return_call_Application_GetAll_once()
        {
            //Arrange
            var getAllResult = new List<ItemResponseDto>
            {
                new ItemResponseDto
                {
                    Id = 1,
                    Name = "Test"
                }
            };

            this._itemApplication.Setup(r => r.GetAll())
                .ReturnsAsync(getAllResult);

            //Act
            var result = await this._controller.GetAll();

            //Assert
            this._itemApplication.Verify(r =>
                r.GetAll(),
                Times.Once);
        }
    }
}