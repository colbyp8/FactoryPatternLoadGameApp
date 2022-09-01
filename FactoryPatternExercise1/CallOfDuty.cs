using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternExercise1
{
    public class CallOfDuty : IVideoGame
    {
        public CallOfDuty()
        {
        }

        public void Load()
        {
            Console.WriteLine("Call of Duty is loading...");
            Thread.Sleep(3000);
            Console.WriteLine("Bravo Six. Going Dark.");
        }

    }
}
