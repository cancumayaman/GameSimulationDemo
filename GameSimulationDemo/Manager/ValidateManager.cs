using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo.Manager
{
    class ValidateManager
    {
        public void IsValid(Gamer gamer)
        {
            
            if (gamer.IdentityNumber.Length == 11&&gamer.Name.Length>1&&gamer.LastName.Length>1&&(gamer.Dob>1900&&gamer.Dob<2021))
            {
                Console.WriteLine(gamer.Name+" "+gamer.LastName+" is valid");
            }
            else
            {
                Console.WriteLine(gamer.Name + " " + gamer.LastName + " is not valid");
            }
        }

    }
}
