using GameSimulationDemo.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo.Manager
{
    class GamerManager : IGamerServices
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.Name+" "+gamer.LastName+" added");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " " + gamer.LastName + " deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " " + gamer.LastName + " updated");
        }
    }
}
