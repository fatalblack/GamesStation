using GamesStation.SuperExampleGame.Application.Interfaces;
using GamesStation.SuperExampleGame.Dto.CharacterInventoryDtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreApplication _storeApplication;

        public StoreController(IStoreApplication storeApplication)
        {
            this._storeApplication = storeApplication;
        }

        [HttpPost("buy")]
        public async Task<IActionResult> Buy([FromBody] CharacterInventoryAddRequestDto request)
        {
            //TODO: funcionalidad
            return Ok(true);
        }
    }
}