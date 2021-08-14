using GameSellProject.Abstract;
using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Concrete
{
    class GameManager : IGameService
    {
        public void AddGame(List<Game> gameList)
        {
            foreach (var game in gameList)
            {
                Console.WriteLine(game.GameName + " Sepetinize eklendi");
            }
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine(game.GameName + " Sepetinizden çıkarıldı");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine(game.GameName + " Sepetinizde güncellendi");
        }
    }
}
