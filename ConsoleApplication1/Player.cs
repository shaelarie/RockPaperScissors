using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Player
    {
        string name;
        int score;
        string userMove;
        string userSecondMove;
        string userLastMove;

        public Player(string name)
        {
            this.name = name;
            this.score = 0;
         }

        public int getScore()
        {
            return this.score;
        }

        public void addOneToScore()
        {
            this.score += 1;
            
        }
        public string getName()
        {
            return this.name;
        }
        public void changeName(string name)
        {
            this.name = name;
        }
        public void setuserfirstMove(string userMove)
        {
            Console.WriteLine("Please make your first move");
            this.userMove = Console.ReadLine();            
        }

        public void setuserSecondMove(string userSecondMove)
        {
            Console.WriteLine("Please make your next move");
            this.userSecondMove = Console.ReadLine();
        }

        public void setuserLastMove(string userLastMove)
        {
            Console.WriteLine("Please make your last move");
            this.userLastMove = Console.ReadLine();
        }
    }

}
