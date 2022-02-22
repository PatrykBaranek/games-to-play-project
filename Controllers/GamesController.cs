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
    public class GamesController : Controller
    {

        private readonly IGamesService _gamesService;

        public GamesController(IGamesService gamesService)
        {
            _gamesService = gamesService;
        }

        [HttpGet]
        public async Task<IActionResult> MyList()
        {
            var gamesList = await _gamesService.MyList();

            return View(gamesList);
        }

        [HttpGet]
        public async Task<IActionResult> GameDetails(int? id)
        {
            var game = await _gamesService.GameDetails(id);

            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        [HttpGet]
        public IActionResult AddNewGameForm()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewGame(GamesEntity newGameData)
        {
            var newGame = await _gamesService.AddNewGame(newGameData);

            if (newGame == null)
            {
                return BadRequest();
            }

            return RedirectToAction("MyList");
        }

        [HttpGet]
        public async Task<IActionResult> EditGameForm(int? id)
        {
            var game = await _gamesService.EditGameForm(id);

            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        [HttpPut("Games/EditGame/{id}")]
        public async Task<IActionResult> EditGame(int? id, GamesEntity game)
        {
            var newGameStats = await _gamesService.EditGame(id,game);

            if (newGameStats == null)
            {
                return BadRequest();
            }


            return NoContent();
        }

        [HttpDelete("Games/DeleteGame/{id}")]
        public async Task<IActionResult> DeleteGame(int? id)
        {
            var gameToDelete = await _gamesService.DeleteGame(id);

            if (gameToDelete == null)
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}
