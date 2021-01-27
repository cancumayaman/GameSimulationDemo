using GameSimulationDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo.Services
{
    interface IGameServices
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        void SellGame(Game game,Gamer gamer,Campaign campaign);
    }
}
