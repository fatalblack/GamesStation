using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Dto.ItemDtos;
using GamesStation.SuperExampleGame.Infrastructure.Interfaces;
using GamesStation.SuperExampleGame.Service.Interfaces;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Service.Tests.ItemServiceTests
{
    [TestFixture]
    public class GetAllTest
    {
        private IItemService _service;
        private Mock<IItemRepository> _repository;

        [SetUp]
        public void SetUp()
        {
            this._repository = new Mock<IItemRepository>();

            this._service = new ItemService(
                this._repository.Object);
        }

        [Test]
        [Category("Service"), Category("Item"), Category("GetAll")]
        public async Task Must_return_List_ItemResponseDto()
        {
            //Arrange
            var getAllResult = new List<Item>
            {
                new Item
                {
                    Id = 1,
                    Name = "Test",
                    Description = "Another test"
                }
            };

            this._repository.Setup(r => r.GetAll())
                .ReturnsAsync(getAllResult);

            //Act
            var result = await this._service.GetAll();

            //Assert
            Assert.IsAssignableFrom<List<ItemResponseDto>>(result);
        }

        [Test]
        [Category("Service"), Category("Item"), Category("GetAll")]
        public async Task Must_return_call_Repository_GetAll_once()
        {
            //Arrange
            var getAllResult = new List<Item>
            {
                new Item
                {
                    Id = 1,
                    Name = "Test",
                    Description = "Another test"
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