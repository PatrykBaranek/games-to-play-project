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
    }
}
