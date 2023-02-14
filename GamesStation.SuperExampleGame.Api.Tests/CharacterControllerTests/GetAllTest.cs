using GamesStation.SuperExampleGame.Api.Controllers;
using GamesStation.SuperExampleGame.Application.Interfaces;
using GamesStation.SuperExampleGame.Dto.CharacterDtos;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Api.Tests.CharacterControllerTests
{
    [TestFixture]
    public class GetAllTest
    {
        private CharacterController _controller;
        private Mock<ICharacterApplication> _characterApplication;

        private readonly int OK_STATUS_CODE = 200;

        [SetUp]
        public void SetUp()
        {
            this._characterApplication = new Mock<ICharacterApplication>();

            this._controller = new CharacterController(
                this._characterApplication.Object);
        }

        [Test]
        [Category("Controller"), Category("Character"), Category("GetAll")]
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

            this._characterApplication.Setup(r => r.GetAll())
                .ReturnsAsync(getAllResult);

            //Act
            var actionResult = await this._controller.GetAll();
            var result = actionResult as OkObjectResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(this.OK_STATUS_CODE, result.StatusCode);
            Assert.IsAssignableFrom<List<CharacterResponseDto>>(result.Value);
        }

        [Test]
        [Category("Controller"), Category("Character"), Category("GetAll")]
        public async Task Must_return_call_Application_GetAll_once()
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

            this._characterApplication.Setup(r => r.GetAll())
                .ReturnsAsync(getAllResult);

            //Act
            var result = await this._controller.GetAll();

            //Assert
            this._characterApplication.Verify(r =>
                r.GetAll(),
                Times.Once);
        }
    }
}