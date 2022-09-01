using System;
using System.Collections.Generic;
using System.Threading;

namespace FactoryPatternExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What game would you like to load? Options: Call of Duty, Mortal Combat, NCAA Football");
            string game = Console.ReadLine();
            var load = GameLoader.LoadGame(game);
            load.Load();

        }
    }
}
