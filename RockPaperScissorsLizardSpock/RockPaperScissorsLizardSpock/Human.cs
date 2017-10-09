using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Human : Player
    {
        //member variables

        //constructor

        //member methods
        public override void GetGesture()
        {
            Console.WriteLine("Make your choice:\n[1] Rock\n[2] Paper\n[3] Scissors\n[4] Lizard\n[5] Spock");
            string playerNumberChoice = Console.ReadLine();
            switch (playerNumberChoice)
            {
                case "1":
                    gesture = 1; //"Rock"
                    break;
                case "2":
                    gesture = 2; //Paper
                    break;
                case "3":
                    gesture = 3;  //Scissors
                    break;
                case "4":
                    gesture = 4; //Lizard
                    break;
                case "5":
                    gesture = 5; //Spock
                    break;
                default:
                    Console.WriteLine("Invalid selection.  Please type in '1' '2' '3' '4' or '5'");
                    GetGesture();
                    break;
            }
        }
    }
}
