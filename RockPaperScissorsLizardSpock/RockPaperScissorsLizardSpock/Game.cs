using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        //member variables
        string rules = "Rules for Rock, Paper, Scissors, Lizard, Spock:\n\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n(and as it always has) Rock crushes Scissors";
        string playerOneName;
        int playerOneWinCount = 0;
        int playerTwoWinCount = 0;
        //constructor
        public Game() {

        }
        //player 1 = human
        //player 2, human or computer?

        //member methods
        void DisplayRules()
        {
            Console.WriteLine(rules);
            Console.ReadLine();
        }
        void CreatePlayerOne()
        {
            Console.WriteLine("Welcome Player 1.  What is your name?");
            playerOneName = Console.ReadLine();   
        }
        public void CreatePlayerTwo()
        {
            Console.WriteLine("Will you be challenging [1] another player or [2] the computer?");
            string challengeWhom = Console.ReadLine();
            switch (challengeWhom)
            {
                case "1":
                    Human humanPlayerTwo = new Human();
                    break;
                case "2":
                    Computer computerPlayerTwo = new Computer();
                    break;
                default:
                    Console.WriteLine("Invalid entry.  Please type in '1' or '2'");
                    CreatePlayerTwo();
                    break;
            }
        }

        //void PlayRound()
        //{
        //    PlayerOneGesture();
        //    PlayerTwoGesture();
        //    //if player 1 wins, playerOneWinCount += 1
        //    //if player 2 wins, playerTwoWinCount += 1
        //}

        public void RunGame()
        {
            DisplayRules();
            CreatePlayerOne();
            CreatePlayerTwo();
            //PlayRound();

        }
    }
}

