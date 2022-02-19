using GamesToPlayProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesToPlayProject.Services
{
    public interface IGamesService
    {
        Task<IEnumerable<GamesEntity>> MyList();
        Task<GamesEntity> GameDetails(int? id);
        Task<GamesEntity> AddNewGame(GamesEntity newGameData);
    }
}
