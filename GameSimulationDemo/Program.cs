using GameSimulationDemo.Entities;
using GameSimulationDemo.Manager;
using GameSimulationDemo.Services;
using System;

namespace GameSimulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer() { Id = 1, IdentityNumber = "11111111111", Name = "Can", LastName = "Yaman", Dob = 1998 };
            Gamer gamer2 = new Gamer() { Id = 2, IdentityNumber = "22222222222", Name = "Ceren", LastName = "Yaman", Dob = 2008 };
            Gamer gamer3 = new Gamer() { Id = 3, IdentityNumber = "33333333333", Name = "Neslihan", LastName = "Yaman", Dob = 2004 };
            IGamerServices gamerManager = new GamerManager();
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Add(gamer3);
            
            ValidateManager validateManager = new ValidateManager();
            validateManager.IsValid(gamer1);
            validateManager.IsValid(gamer2);
            validateManager.IsValid(gamer3);
            Game game1 = new Game() { Id = 1, Name = "GTA", Price = 100 };
            Game game2 = new Game() { Id = 2, Name = "FIFA 2021", Price = 200 };
            Game game3 = new Game() { Id = 3, Name = "CALL OF DUTY", Price = 300 };
            IGameServices gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);

            Campaign campaign1 = new Campaign() { Id = 1, Name = "Student Campaign", StartingDate = 2020, EndDate = 2022 };
            Campaign campaign2 = new Campaign() { Id = 2, Name = "Black Friday Campaign", StartingDate = 2020, EndDate = 2021 };
            Campaign campaign3 = new Campaign() { Id = 3, Name = "Gamer Campaign", StartingDate = 2021, EndDate = 2022 };
            ICampaignServices campaignServices = new CampaignManager();
            campaignServices.Add(campaign1);
            campaignServices.Add(campaign2);
            campaignServices.Add(campaign3);
            gameManager.SellGame(game1, gamer1,campaign1);
            gameManager.SellGame(game2, gamer2,campaign2);
            gameManager.SellGame(game3, gamer3,campaign3);



        }
    }
}
