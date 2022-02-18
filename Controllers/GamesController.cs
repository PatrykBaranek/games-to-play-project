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

        //[HttpGet]
        //public Task<IActionResult> GameDetails()
        //{
            
        //}
    }
}
