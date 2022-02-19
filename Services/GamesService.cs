using GamesToPlayProject.Database;
using GamesToPlayProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesToPlayProject.Services
{
    public class GamesService : IGamesService
    {
        private readonly AppDbContext _dbContext;

        public GamesService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }        

        public async Task<IEnumerable<GamesEntity>> MyList()
        {
            var gamesList = await _dbContext.Games.ToListAsync();

            return gamesList;
        }

        public async Task<GamesEntity> GameDetails(int? id)
        {
            var game = await _dbContext.Games.FirstOrDefaultAsync(x => x.Id == id);

            return game;
        }

        public async Task<GamesEntity> AddNewGame(GamesEntity newGameData)
        {
            var newGame = new GamesEntity()
            {
                Title = newGameData.Title,
                TimeSpent = newGameData.TimeSpent,
                IsFinished = newGameData.IsFinished,
                ImgUrl = newGameData.ImgUrl,
            };

            await _dbContext.Games.AddAsync(newGame);
            await _dbContext.SaveChangesAsync();

            return newGame;
        }
    }
}
