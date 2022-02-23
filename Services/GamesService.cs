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

            if (newGame == null)
            {
                return null;
            }

            await _dbContext.Games.AddAsync(newGame);
            await _dbContext.SaveChangesAsync();

            return newGame;
        }

        public async Task<GamesEntity> EditGameForm(int? id)
        {
            var game = await _dbContext.Games.FirstOrDefaultAsync(g => g.Id == id);

            return game;
        }

        public async Task<GamesEntity> EditGame(int? id, GamesEntity game)
        {
            var gameToEdit = await _dbContext.Games.FindAsync(id);

            if (gameToEdit != null)
            {
                gameToEdit.Title = game.Title;
                gameToEdit.TimeSpent = game.TimeSpent;
                gameToEdit.ImgUrl = game.ImgUrl;
                gameToEdit.IsFinished = game.IsFinished;
                await _dbContext.SaveChangesAsync();
            }

            return gameToEdit;
        }

        public async Task<GamesEntity> DeleteGame(int? id)
        {
            var gameToDelete = await _dbContext.Games.FindAsync(id);

            if (gameToDelete == null)
            {
                return null;
            }

            _dbContext.Games.Remove(gameToDelete);
            await _dbContext.SaveChangesAsync();

            return gameToDelete;
        }
    }
}
