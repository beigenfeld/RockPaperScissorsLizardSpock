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

        int playerOneWinCount = 0;
        int playerTwoWinCount = 0;
        //constructor
        public Game() {
            
            }
        //player 1 = human
        //player 2, human or computer?

        //member methods
        void CreatePlayerOne() {
            Console.WriteLine("Welcome Player 1.  What is your name?");
            this.name = Console.ReadLine();
            Console.WriteLine("Will you be challenging [1] another player or [2] the computer?");
            switch ()
            {
                case '1':
                    //create player 2 as human
                    break;
                case '2':
                    //create player 2
                    break;
                default:
                    Console.WriteLine("Invalid entry, please enter '1' or '2'");
                    SelectPlayerTwo();
                    break;
            }
        }
        public void CreatePlayerTwo()
        {
            Console.WriteLine(rules + "\nPress enter to continue to Setup");
            string challengeWhom = Console.ReadLine();
                switch(challengeWhom) 
                {
                    case "1":
                        //new player = human
                        break;
                    case "2":
                        //new player = computer
                        break;
                    default:
                        Console.WriteLine("Invalid entry.  Please type in '1' or '2'");
                        SelectPlayerTwo();
                        break;
                }
            
         }
        }
        void PlayRound ()
        {
            PlayerOneGesture();
            PlayerTwoGesture();
            //if player 1 wins, playerOneWinCount += 1
            //if player 2 wins, playerTwoWinCount += 1
        }
}
