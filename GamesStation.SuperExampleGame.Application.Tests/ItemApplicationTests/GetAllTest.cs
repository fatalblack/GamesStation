using GamesStation.SuperExampleGame.Application.Interfaces;
using GamesStation.SuperExampleGame.Dto.ItemDtos;
using GamesStation.SuperExampleGame.Service.Interfaces;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Application.Tests.ItemApplicationTests
{
    [TestFixture]
    public class GetAllTest
    {
        private IItemApplication _application;
        private Mock<IItemService> _itemService;

        [SetUp]
        public void SetUp()
        {
            this._itemService = new Mock<IItemService>();

            this._application = new ItemApplication(
                this._itemService.Object);
        }

        [Test]
        [Category("Application"), Category("Item"), Category("GetAll")]
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

            this._itemService.Setup(r => r.GetAll())
                .ReturnsAsync(getAllResult);

            //Act
            var result = await this._application.GetAll();

            //Assert
            Assert.IsAssignableFrom<List<ItemResponseDto>>(result);
        }

        [Test]
        [Category("Application"), Category("Item"), Category("GetAll")]
        public async Task Must_return_call_Service_GetAll_once()
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

            this._itemService.Setup(r => r.GetAll())
                .ReturnsAsync(getAllResult);

            //Act
            var result = await this._application.GetAll();

            //Assert
            this._itemService.Verify(r =>
                r.GetAll(),
                Times.Once);
        }
    }
}