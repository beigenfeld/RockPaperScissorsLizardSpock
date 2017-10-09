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
        string rules = "Rules for Rock, Paper, Scissors, Lizard, Spock:\n\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n(and as it always has) Rock crushes Scissors\nTwo out of three wins the game";
        Player playerOne;
        Player playerTwo;

        //constructor

        void DisplayRules()
        {
            Console.WriteLine(rules);
            Console.ReadLine();
        }
        void CreatePlayerOne()
        {
            Console.WriteLine("Welcome Player 1.  What is your name?");
            playerOne = new Human();
            playerOne.name = Console.ReadLine();
        }
        public void CreatePlayerTwo()
        {
            Console.WriteLine("Will you be challenging [1] another player or [2] the computer?");
            string challengeWhom = Console.ReadLine();
            switch (challengeWhom)
            {
                case "1":
                    playerTwo = new Human();
                    Console.WriteLine("Hello Player 2.  What is your name?");
                    playerTwo.name = Console.ReadLine();
                    break;
                case "2":
                    playerTwo = new Computer();
                    break;
                default:
                    Console.WriteLine("Invalid entry.  Please type in '1' or '2'");
                    CreatePlayerTwo();
                    break;
            }
        }
        public void CompareGestures()
        {
            Console.WriteLine(playerOne.name + " selected " + playerOne.gestureName + " and " + playerTwo.name + " selected " + playerTwo.gestureName);

            if (playerOne.gesture == 1 && (playerTwo.gesture == 3 || playerTwo.gesture == 4))
            {
                Console.WriteLine(playerOne.name + " wins this Round");
                playerOne.score += 1;
            }

            else if (playerOne.gesture == 2 && (playerTwo.gesture == 1 || playerTwo.gesture == 5))
            {
                Console.WriteLine(playerOne.name + " wins this Round");
                playerOne.score += 1;
            }

            else if (playerOne.gesture == 3 && (playerTwo.gesture == 3 || playerTwo.gesture == 4))
            {
                Console.WriteLine(playerOne.name + " wins this Round");
                playerOne.score += 1;
            }

            else if (playerOne.gesture == 4 && (playerTwo.gesture == 3 || playerTwo.gesture == 4))
            {
                Console.WriteLine(playerOne.name + " wins this Round");
                playerOne.score += 1;
            }

            else if (playerOne.gesture == 5 && (playerTwo.gesture == 3 || playerTwo.gesture == 4))
            {
                Console.WriteLine(playerOne.name + " wins this Round");
                playerOne.score += 1;
            }

            else if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("You tied! Try again!");
            }

            else {
                Console.WriteLine(playerTwo.name + " wins this Round");
                playerTwo.score += 1;
            }
        }
    
    void PlayRound()
    {
        Console.WriteLine(playerOne.name + ", make your selection");
        playerOne.GetGesture();
        Console.WriteLine(playerTwo.name + ", make your selection");
        playerTwo.GetGesture();
        CompareGestures();
    }

    public void CheckScore()
    {
        Console.WriteLine(playerOne.name + "'s score is " + playerOne.score + " and " + playerTwo.name + "'s score is " + playerTwo.score);
        if (playerOne.score == 2)
        {
            Console.WriteLine(playerOne.name + ", you have won the Game!");
        }
        else if (playerTwo.score == 2)
        {
            Console.WriteLine(playerTwo.name + " has won the Game!");
        }
        else
        {
            PlayRound();
        }
        Console.ReadLine();
    }
    public void RunGame()
    {
        DisplayRules();
        CreatePlayerOne();
        CreatePlayerTwo();
        PlayRound();
        CheckScore();
    }
}
}

