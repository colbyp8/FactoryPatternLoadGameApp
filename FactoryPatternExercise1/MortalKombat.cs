using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternExercise1
{
    public class MortalKombat : IVideoGame
    {
        public MortalKombat()
        {
        }

        public void Load()
        {
            Console.WriteLine("Mortal Kombat is loading...");
            Thread.Sleep(3000);
            Console.WriteLine("Finish Him!");
        }

    }
}
