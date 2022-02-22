using GamesToPlayProject.Entities;
using GamesToPlayProject.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesToPlayProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesApiController : ControllerBase
    {

        private readonly IGamesService _gamesService;

        public GamesApiController(IGamesService gamesService )
        {
            _gamesService = gamesService;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditGame(int? id, [FromBody]GamesEntity game)
        {
            var editGame = await _gamesService.EditGame(id, game);

            if(editGame == null)
            {
                return BadRequest();
            }

            return Ok();
        }

    }
}
