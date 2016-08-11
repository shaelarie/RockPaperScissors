using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Game
    {
        Random computer;
        List<string> compMoves = new List<string>() { "Rock", "Paper", "Scissors" };
        Player playerUser;
        string playerMove;        
        string compMove;
        Intro intro;
        Scores scores;
        int round;
        int numberOfRounds;


        public Game()
        {
        
            this.computer = new Random();
            this.compMove = compMoves[(computer.Next(0, compMoves.Count))];
            this.playerUser = new Player(playerMove);
            this.intro = new Intro();
            this.round = 1;
            this.numberOfRounds = 3;
            this.scores = new Scores(playerUser);
        }

        public void RunGame(string username)
        {
            while (this.round <= this.numberOfRounds)
            {
                Console.WriteLine("Welcome to Round {0} Please make your move", this.round);
            this.playerMove = Console.ReadLine();
            string compMove = compMoves[(computer.Next(0, compMoves.Count))];
            Console.WriteLine(compMove);

            
                if (compMove == "Rock" && playerMove == "Rock")
                {

                    Console.WriteLine("Its a tie! Let's try that again. You have {0} points", playerUser.getScore());
                    RunGame(playerMove);

                }

                else if (compMove == "Rock" && playerMove == "Paper")
                {
                    playerUser.addOneToScore();
                    Console.WriteLine("You win! You have {0} points", playerUser.getScore());

                    this.round++;

                }
                else if (compMove == "Rock" && playerMove == "Scissors")
                {
                    Console.WriteLine("You lose! You have {0} points", playerUser.getScore());
                    this.round++;

                }
                else if (compMove == "Paper" && playerMove == "Rock")
                {
                    playerUser.addOneToScore();
                    Console.WriteLine("You win! You have {0} points", playerUser.getScore());

                    this.round++;
                }
                else if (compMove == "Paper" && playerMove == "Paper")
                {
                    Console.WriteLine("It's a tie! Let's try that again. You have {0} points", playerUser.getScore());
                    RunGame(playerMove);

                }
                else if (compMove == "Paper" && playerMove == "Scissors")
                {
                    playerUser.addOneToScore();
                    Console.WriteLine("You win! You have {0} points", playerUser.getScore());

                    this.round++;
                }
                else if (compMove == "Scissors" && playerMove == "Rock")
                {
                    playerUser.addOneToScore();
                    Console.WriteLine("You win! You have {0} points", playerUser.getScore());

                    this.round++;
                }
                else if (compMove == "Scissors" && playerMove == "Paper")
                {
                    Console.WriteLine("You lose! You have {0} points", playerUser.getScore());
                    this.round++;

                }
                else if (compMove == "Scissors" && playerMove == "Scissors")
                {
                    Console.WriteLine("It's a tie! Let's try that again. You have {0} points", playerUser.getScore());
                    RunGame(playerMove);
                }
                else
                {
                    Console.WriteLine("Invalid entry, try making first letter uppercase. Ex. 'Rock' Try again!");
                    RunGame(playerMove);

                }
            }
                    scores.finalScore(playerUser);
        }


       
            
        }

    }

