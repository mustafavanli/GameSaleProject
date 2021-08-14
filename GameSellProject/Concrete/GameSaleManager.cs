using GameSellProject.Abstract;
using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        public void Sale(List<Game> games, Gamer gamer,Campaign campaign)
        {
            double TotalPrice = 0;
            foreach (var item in games)
            {
                TotalPrice += item.GamePrice;
            }
            TotalPrice = (TotalPrice * campaign.CampaignDiscount) / 100;  // Yüzdesel indirim.
                                                                          
            Console.WriteLine(gamer.FirstName + " isimli oyuncuya bugüne özel " + campaign.CampaignName + 
                "\nisimli kampanyadan dolayı % " + campaign.CampaignDiscount + " kadar indirim kazandınız ve yeni harcama tutarı: "
                + TotalPrice);
        }
    }
}
