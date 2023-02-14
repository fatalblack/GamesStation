using GamesStation.SuperExampleGame.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemApplication _itemApplication;

        public ItemController(IItemApplication itemApplication)
        {
            this._itemApplication = itemApplication;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            //TODO: funcionalidad
            return Ok(true);
        }
    }
}