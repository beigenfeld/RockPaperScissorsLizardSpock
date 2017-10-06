using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Paper : Gesture
    {
        //member variables

        //constructor
        //wins against: rock, Spock
        //loses against: scissors, lizard

        //member methods
        void DoesPaperWin()
        {
            if (playerTwoSelection == Rock || playerTwoSelection == Spock) {
                //player 1 wins
            }
            else {
                //player 2 wins
            }
        }
    }
}
