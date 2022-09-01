using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise1
{
    public static class GameLoader
    {
        //write a method to load whatever game is selected
        public static IVideoGame LoadGame(string game)
        {
            switch (game.ToLower())
            {
                case "call of duty":
                    return new CallOfDuty();
                case "mortal kombat":
                    return new MortalKombat();
                case "ncaa football":
                    return new NCAAFootball();
                default:
                    return new MarioKart();
                    
            }
        }
    }
}
