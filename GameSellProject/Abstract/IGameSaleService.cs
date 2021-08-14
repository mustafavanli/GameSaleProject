using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Abstract
{
    interface IGameSaleService
    {
        void Sale(List<Game> games,Gamer gamer,Campaign campaign);

    }
}
