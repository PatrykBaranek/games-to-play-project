using GamesToPlayProject.Entities;
using GamesToPlayProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesToPlayProject.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class GamesApiController : ControllerBase
    {

        private readonly IGamesService _gamesService;

        public GamesApiController(IGamesService gamesService)
        {
            _gamesService = gamesService;
        }

        [HttpPut("editgame/{id}")]
        public async Task<IActionResult> EditGame([FromRoute] int? id, [FromBody] GamesEntity game)
        {
            var editGame = await _gamesService.EditGame(id, game);

            if (editGame == null)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete("deletegame/{id}")]
        public async Task<IActionResult> DeleteGame([FromRoute] int? id)
        {
            await _gamesService.DeleteGame(id);

            if (id == null)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
