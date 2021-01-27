using GameSimulationDemo.Entities;
using GameSimulationDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo.Manager
{
    class CampaignManager : ICampaignServices
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+" added at "+campaign.StartingDate);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " deleted at" + campaign.StartingDate);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " updated at " + campaign.StartingDate);
        }
    }
}
