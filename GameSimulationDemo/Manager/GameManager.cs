using GameSimulationDemo.Entities;
using GameSimulationDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo.Manager
{
    class GameManager : IGameServices
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name+" added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " deleted");
        }

        public void SellGame(Game game, Gamer gamer,Campaign campaign)
        {
            Console.WriteLine(game.Name+ " purchased by " + gamer.Name+" "+gamer.LastName+" for "+game.Price+" $ with "+campaign.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " updated");
        }
    }
}
