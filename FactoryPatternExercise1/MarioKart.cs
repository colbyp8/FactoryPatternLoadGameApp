using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternExercise1
{
    public class MarioKart : IVideoGame
    {
        public MarioKart()
        {
        }

        public void Load()
        {
            Console.WriteLine("We don't have that one but here's a game you might like.");
            Console.WriteLine("Mario Kart is now loading...");
            Thread.Sleep(3000);
            Console.WriteLine("It's-a Mario time!");
        }
    }
}
