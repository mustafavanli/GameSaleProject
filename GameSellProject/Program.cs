using GameSellProject.Entities;
using GameSellProject.Abstract;
using GameSellProject.Concrete;
using System;
using System.Collections.Generic;

namespace GameSellProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------- OYUNCU BİLGİSİ ----------------
            Gamer gamer = new Gamer() { 
                Id = 1,
                FirstName = "Mustafa",
                LastName = "Vanlı",
                BirthYear = 2003,
                IdentityNumber = 123456789 // Doğrulama IdentityNumber üzerinden çalışıyor ve 9 haneli ise doğru diyor
            };
            // ------------- OYUNCU BİLGİSİ ----------------
            // ------------- OYUN BİLGİSİ ----------------
            List<Game> OrderGame = new List<Game>(); // sepette depolama
            Game game = new Game() {
                Id = 1,
                GameName = "GTAV",
                GameCategory = 2,
                GamePrice = 180
            };
            Game game2 = new Game()
            {
                Id = 2,
                GameName = "İce Tower",
                GameCategory = 1,
                GamePrice = 50
            };
            OrderGame.Add(game);
            OrderGame.Add(game2);
            // ------------- OYUN BİLGİSİ ----------------
            // ------------- KAMPANYA BİLGİSİ ----------------
            // eğer kampanya YOK İSE null olarak girilmelidir , Örnek: Campaign campaign = null;
            Campaign campaign = new Campaign() {
                Id = 1, // Kampanya ID si
                CampaignName = "%50 INDIRIM SOLENI", // Kampanya ADI
                CampaignDiscount = 50  // Kampanya indirimi % biriminden
            };
            // ------------- KAMPANYA BİLGİSİ ----------------

            GamerManager gamerManager = new GamerManager(new VerifactionManager());
            gamerManager.Add(gamer);
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            GameManager gameManager = new GameManager();
            gameManager.AddGame(OrderGame);
            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(OrderGame,gamer,campaign); // Oyun sepeti , oyuncu , kampanya
        }
    }
}
