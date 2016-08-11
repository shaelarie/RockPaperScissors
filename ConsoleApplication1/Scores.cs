using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Scores
    {
        Random computer;
        List<string> compMoves = new List<string>() { "Rock", "Paper", "Scissors" };
        Player playerUser;
        string playerMove;

        string compMove;
        Intro intro;


        public Scores(Player player)
        {

            this.computer = new Random();
            this.compMove = compMoves[(computer.Next(0, compMoves.Count))];
            this.playerUser = player;
            this.intro = new Intro();

        }



        public void finalScore(Player player)
        {
            Console.WriteLine("Your final score is {0}", playerUser.getScore());
            int finalscore = playerUser.getScore();
            if (finalscore < 2)
            {
                Console.WriteLine("GAME OVER");
                Console.WriteLine("You Lose! Thanks for playing");
                Console.ReadLine();

            }
            else if (finalscore >= 2)
            {
                Console.WriteLine("GAME OVER");
                Console.WriteLine("You win! Thanks for playing");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Technical Dificulies");
            }
        }
    }
}
