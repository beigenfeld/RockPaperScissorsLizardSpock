using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Scissors : Gesture
    {
        //member variables

        //constructor
        //wins against: paper, lizard
        //loses against: rock, Spock

        //member methods
        void DoesScissorsWin()
        {
            if (playerTwoSelection == Paper || playerTwoSelection == Lizard) {
                //player 1 wins
            }
            else {
                //player 2 wins
            }
        }
    }
}
