using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        //member variables
        string name;
        //constructor
        void HumanPlayer()
        {
            Console.WriteLine("Welcome Player 2.  What is your name?");
            this.name = Console.ReadLine();
        }
        //member methods
        
    }
}
