using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternExercise1
{
    public class NCAAFootball : IVideoGame
    {
        public NCAAFootball()
        {
        }

        public void Load()
        {
            Console.WriteLine("NCAA Football is loading...");
            Thread.Sleep(3000);
            Console.WriteLine("EA Sports. It's in the game.");
        }
    }
}
