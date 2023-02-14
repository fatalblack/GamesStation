using GamesStation.SuperExampleGame.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterApplication _characterApplication;

        public CharacterController(ICharacterApplication characterApplication)
        {
            this._characterApplication = characterApplication;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await this._characterApplication.GetAll();
            return Ok(result);
        }
    }
}