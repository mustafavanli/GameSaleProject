using GameSellProject.Abstract;
using GameSellProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            if (campaign != null)
            {
                Console.WriteLine(campaign.CampaignName + " İsimli kampanya uygulandı");
            }
        }

        public void Delete(Campaign campaign)
        {
            if (campaign != null)
            {
                Console.WriteLine(campaign.CampaignName + " İsimli kampanya silindi");
            }
        }

        public void Update(Campaign campaign)
        {
            if (campaign != null)
            {
                Console.WriteLine(campaign.CampaignName + " İsimli kampanya güncellendi");
            }
        }
    }
}
