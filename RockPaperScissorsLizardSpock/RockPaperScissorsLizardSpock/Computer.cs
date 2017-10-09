using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        //member variables
        Random rdm = new Random();

        //constructor
        public Computer()
        {
            name = "The Computer";
        }
        //member methods
        public override void GetGesture()
        {
            int num = rdm.Next(1, 6);
            switch (num)
            {
                case 1:
                    gesture = 1;
                    gestureName = "Rock";
                    break;
                case 2:
                    gesture = 2;
                    gestureName = "Paper";
                    break;
                case 3:
                    gesture = 3;
                    gestureName = "Scissors";
                    break;
                case 4:
                    gesture = 4;
                    gestureName = "Lizard";
                    break;
                case 5:
                    gesture = 5;
                    gestureName = "Spock";
                    break;
            }
            Console.Clear();
            
        }
    }
}
