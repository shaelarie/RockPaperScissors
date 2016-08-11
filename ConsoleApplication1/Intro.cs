using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Intro
    {

        Alternate alternate;
        Player playerUser;
        string playerMove;

        public Intro()
        {
            this.alternate = new Alternate();

            this.playerUser = new Player(playerMove);
        }


        public void introduction(string userName)
        {
            Console.WriteLine("It's nice to meet you {0}", userName);

            Console.Write("Would you like to play a game? \n");
            string story = Console.ReadLine();
            switch (story)
            {
                case "yes":
                    Console.WriteLine("Great! The game is Rock, Paper, Scissors. Your move options are 'Rock'" +
                        "'Paper' or 'Scissors'. Rock beats Scissors, Paper beats Rock, Scissors beats Paper." +
                        "if we both make the same move its a tie! Let's get started!");
                    break;
                case "no":
                    alternate.noGame();
                    break;
                default:
                    Console.WriteLine("That doesn't answer my question");
                    alternate.noGame();
                    break;

            }
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

