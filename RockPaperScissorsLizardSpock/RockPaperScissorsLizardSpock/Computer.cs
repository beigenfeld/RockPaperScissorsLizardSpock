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
        public string name = new ("The Computer");
        Random rdm = new Random();
        
        //constructor

        //member methods
        public override void GetGesture()
        {
            int num = rdm.Next(1, 6);
            switch (num)
            {
                case 1:
                    gesture = 1;
                    break;
                case 2:
                    gesture = 2;
                    break;
                case 3:
                    gesture = 3;
                    break;
                case 4:
                    gesture = 4;
                    break;
                case 5:
                    gesture = 5;
                    break;
            }
        }
    }
}
