using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Abstract
{
    interface IGameService
    {
        void AddGame(List<Game> game);
        void UpdateGame(Game game);
        void DeleteGame(Game game);
    }
}
