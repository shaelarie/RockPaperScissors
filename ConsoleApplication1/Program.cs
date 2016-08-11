using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What is your name?");
            string userSetsName = Console.ReadLine();
            Intro intro = new Intro();
            intro.introduction(userSetsName);
            Game Game = new Game();
            Game.RunGame(userSetsName);
            Console.ReadLine();
            

            


        }
    }
}
